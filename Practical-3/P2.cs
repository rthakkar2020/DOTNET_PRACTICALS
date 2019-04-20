﻿using System;
namespace p3
{
    namespace p3a1
    {
        class Program
        {
            public int ID { get; set; }
            public string Name { get; set; }
            String name, branch;
            int enrol;
            public Program(String name)
            {
                this.name = name;
                Console.WriteLine("constructor 1:" + name);
            }
            public Program(String name, int enrol)
            {
                this.name = name;
                this.enrol = enrol;
                Console.WriteLine("constructor 2:" + name + " " + enrol);

            }
            public Program(String name, int enrol, String branch)
            {
                this.name = name;
                this.enrol = enrol;
                this.branch = branch;
                Console.WriteLine("constructor 3:" + name + " " + enrol + " " + branch);

            }
            static void Main(string[] args)
            {
                Program p1 = new Program("bob");
                Program p2 = new Program("bob", 1);
                Program p3 = new Program("bob", 1, "computer");
                Console.ReadLine();

            }
        }
    }

}
