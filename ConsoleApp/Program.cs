﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NPOI.OpenXmlFormats.Spreadsheet;

namespace ConsoleApp
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    public class Class1
    {
        static void Main(string[] args)
        {
            string filename = Path.Combine(Directory.GetCurrentDirectory(), "lgcr.torrent");
            var data=Torrent.DecodeFile(filename);
            ShowData(data);
        }

        private static void ShowData(ItemBase data)
        {
            if (data.ItemType == ItemType.Dictionary)
            {
                foreach (var kv in (data as DictionaryItem).DictionaryData)
                {
                    switch (kv.Value.ItemType)
                    {
                        case ItemType.Dictionary:
                            Console.WriteLine(kv.Key+":");
                            ShowData(kv.Value);
                            break;
                        case ItemType.List:
                            ShowData(kv.Value);
                            break;
                        case ItemType.String:
                            if (kv.Key == "pieces")
                            {
                                break;
                            }
                            Console.WriteLine(kv.Key + "=" + (kv.Value as StringItem).StringData);
                            break;
                        case ItemType.Number:
                            Console.WriteLine(kv.Key + "=" + (kv.Value as NumberItem).NumberData);
                            break;
                    }
                }
            }
            if (data.ItemType == ItemType.List)
            {
                foreach (var i in (data as ListItem).ListData)
                {
                    switch (i.ItemType)
                    {
                        case ItemType.Dictionary: 
                        case ItemType.List:
                            ShowData(i);
                            break;
                        case ItemType.String:
                            Console.WriteLine( (i as StringItem).StringData);
                            break;
                        case ItemType.Number:
                            Console.WriteLine((i as NumberItem).NumberData);
                            break;
                    }
                }
            }
        }
    }

    public class Torrent
    {
        public static ItemBase DecodeFile(string filename)
        {
            using (var fs = new FileStream(filename, FileMode.Open))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    return DecodeData(br);
                }
            }
        }

        private static ItemBase DecodeData(BinaryReader br)
        {
            var flag = br.PeekChar();
            ItemBase item = null;
            List<byte> ls = new List<byte>();
            byte b = 0;
            switch (flag)
            {
                case 'e':
                    br.ReadByte();
                    break;
                case 'l'://列表
                    br.ReadByte();
                    var itemLs = new ListItem();
                    var i = DecodeData(br);
                    while (i != null && br.BaseStream.Position == br.BaseStream.Length - 2)
                    {
                        var val = DecodeData(br);
                        itemLs.ListData.Add(i);
                        i = DecodeData(br);
                    }

                    item = itemLs;
                    break;
                case 'd'://字典2
                    br.ReadByte();
                    var itemDic = new DictionaryItem();
                    var key = DecodeData(br);
                    while (key != null && br.BaseStream.Position != br.BaseStream.Length)
                    {
                        var val = DecodeData(br);
                        itemDic.DictionaryData[(key as StringItem).StringData] = val;
                        key = DecodeData(br);
                    }

                    item = itemDic;
                    break;
                case 'i'://数字
                    br.ReadByte();
                    b = br.ReadByte();
                    while (b != 'e')
                    {
                        ls.Add(b);
                        b = br.ReadByte();
                    }
                    item = new NumberItem(int.Parse(Encoding.UTF8.GetString(ls.ToArray()))) { RawBytes = ls.ToArray() };
                    break;
                default://字符串 
                    b = br.ReadByte();
                    while (b != ':')
                    {
                        ls.Add(b);
                        b = br.ReadByte();
                    }
                    var len = int.Parse(Encoding.UTF8.GetString(ls.ToArray()));
                    var bufStr = br.ReadBytes(len);
                    var data = Encoding.UTF8.GetString(bufStr);
                    item = new StringItem(data) { RawBytes = bufStr };
                    break;
            }
            return item;
        }
    }

    public class ItemBase
    {
        public ItemType ItemType { get; set; }
        public byte[] RawBytes { get; set; }
    }

    public class StringItem : ItemBase
    {
        public StringItem(string data)
        {
            StringData = data;
            ItemType = ItemType.String;
        }
        public string StringData { get; set; }
    }
    public class NumberItem : ItemBase
    {
        public NumberItem(int num)
        {
            NumberData = num;
            ItemType = ItemType.Number;
        }
        public int NumberData { get; set; }
    }

    public class ListItem : ItemBase
    {
        public ListItem()
        {
            ItemType = ItemType.List;
        }
        public List<ItemBase> ListData { get; set; } = new List<ItemBase>();
    }

    public class DictionaryItem : ItemBase
    {
        public DictionaryItem()
        {
            ItemType = ItemType.Dictionary;
        }
        public Dictionary<string, ItemBase> DictionaryData { get; set; } = new Dictionary<string, ItemBase>();
    }

    public enum ItemType
    {
        String, Number, List, Dictionary
    }
}
