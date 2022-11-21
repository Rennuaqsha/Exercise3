using System;
using System.Runtime.Versioning;
using System.Xml;

namespace Exercise_linked_list_A
{
    class node
    {
        /*creates Nodes for the circular nexted list*/
        public int rollNumber;
        public string name;
        public node next;
    }
    class CircularList
    {
        node Last;

        public CircularList()
        {
            Last = null;
        }

        public bool Serach(int rollNo, ref node previous, ref node current)
        /*Searches for the specified node*/
        {
            for (previous = current = Last.next; current != Last; previous = current, current = current.next)
            {
                if (rollNo == current.next)
                    return (true); /*returns true if the node is found*/
            }
            if (rollNo == Last.rollNumber)/*if the node is present at the end*/
                return true;
            else
                return (false);/*returns false if the node is not found*/
        }
        
        public bool listEmpty()
        {
            if (Last == null)
                return true;
            else 
                return false;
        }

        public void traverse()/*traverses all the nodes of the list*/
        {
            if (listEmpty())
                Console.WriteLine("nlist is empty");
            else
            {
                Console.WriteLine("\nRecords in the list are : \n");
                node currentNode;
                currentNode = Last.next;
                while (currentNode != Last)
                {
                    Console.Write(currentNode.rollNumber + " " + currentNode + "\n");
                    currentNode = currentNode.next;
                }
                Console.Write(Last.rollNumber + " " + Last.name + "n");
            }
        }
        public void FirstNode()
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
                Console.WriteLine("\nThe First record in the list is:\n\n" +
                    Last.next.rollNumber + " " + Last.next.name);
        }

        public void addnode()
        {
            int num;
            string nm;
            Console.Write("\nEnter the roll number off the student: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of student: ");
            nm = Console.ReadLine();
            node newnode = new node();
            newnode.noMhs = num;
            newnode.name = nm;
        }



        static void main(string[] args)
        {
            CircularList obj = new CircularList();  
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. view all the records in the list");
                    Console.WriteLine("2. search for a second in the list");
                    Console.WriteLine("3. display the first record in the list");
                    Console.WriteLine("4. exit");
                    Console.Write("\nEnter your choice (1-4): ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            {
                                obj.traverse();
                            }
                            break;
                        case '2':
                            {
                                if(obj.listEmpty() == true)
                                {
                                    Console.WriteLine("\nList is empty");
                                    break;
                                }
                                node prev, curr;
                                prev = curr = null;
                                Console.Write("\nEnter the roll number of the student whose record is to be searched: ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                if (obj.Serach(num, ref prev, ref curr) == false)
                                    Console.WriteLine("\nRecord not found");
                                else
                                {
                                    Console.WriteLine("\nrecord found");
                                    Console.WriteLine("\nRoll number: " + curr.rollNumber);
                                    Console.WriteLine("\nName: " + curr.name);
                                }
                            }
                            break;
                        case '3':
                            {
                                obj.FirstNode();
                            }
                            break;
                        case '4':
                            return;
                            default:
                            {
                                Console.WriteLine("invalid option");
                                break;
                            }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
