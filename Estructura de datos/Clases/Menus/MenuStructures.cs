﻿using Estructura_de_datos.Clases.Menus;
using System;

namespace Estructura_de_datos.Clases.Extras
{
	public class MenuStructures
	{
        public string Name = "None";

        public static Information _Information = new Information();
        public static MenuStack _ShowMenuStack = new MenuStack();
        public static MenuQueue _ShowMenuQueue = new MenuQueue();
        public static MenuList _ShowMenuList = new MenuList();
        public static MenuTree _ShowMenuTree = new MenuTree();
        public static MenuGraph _ShowMenuGraph = new MenuGraph();

        public string[] _TypeDataStructures = _Information.TypeDataStructures;

        public MenuStructures() { }

        public void PrintArray(Array array, string Name)
        {
            Console.Clear();
            Console.WriteLine("\t@Israel I22050327 Data Structures: " + Name);
            foreach (var item in array)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public int Option(int option)
        {
            try { option = int.Parse(Console.ReadLine()); } catch { }
            var x = (EnumDataStructures)option;
            Console.Clear();
            Menu(option, x);
            return option;
        }

        private void Menu(int Numer, EnumDataStructures DataType)
        {
            Console.Clear();
            switch (DataType)
            {
                case EnumDataStructures.Stack:
                    Console.WriteLine("\"Stack's\"");
                    _ShowMenuStack.CycleStack(Numer);
                    Name = "None";
                    break;

                case EnumDataStructures.Queues:
                    Console.WriteLine("\"Queue's\"");
                    _ShowMenuQueue.CycleQueue(Numer);
                    break;

                case EnumDataStructures.List:
                    Console.WriteLine("\"List's\"");
                    _ShowMenuList.CycleList(Numer);
                    break;

                case EnumDataStructures.Tree:
                    Console.WriteLine("\"Tree's\"");
                    _ShowMenuTree.CycleTree(Numer);
                    break;

                case EnumDataStructures.Graph:
                    Console.WriteLine("\"Graph's\"");
                    _ShowMenuGraph.CycleGraph(Numer);
                    break;

                case EnumDataStructures.Exit:
                    Console.WriteLine("Good Bay :)");
                    Console.ReadKey();
                    break;
            }
        }
    }
}