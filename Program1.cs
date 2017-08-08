using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 链表
{
    class Node<T>
    {
        public Node<T> head;
        public Node<T> next;
        public T value;
        

        public void Print(Node<T> a )
        {
            if (a.next == null)
            {
                Console.Write(a.value);
                return;
            }
            if (a.next!=null);
            {
                Console.Write(a.value);
                Print(a.next);
            }
        }
        
        public void InsertNode(Node<T> a)//a指定insert的位置，在a的后面插入
        {
            next = a.next;
            a.next =this;
            head = a;
            a.next.head =this;
        }

        public void RemoveNode()
        {
           
            if (next == null)
            {
               head.next = null;
               return;
            }
            head.next = next;
            
        }
       

    }

    class Program
    {
        static void Main(string[] args)
        {
            Node<string> name0 = new Node<string>();
            name0.value = null;
            Node<string> name=new Node<string>();
            name.value = "我的名字";
            Node<string> name2 = new Node<string>();
            name2.value = "叫做";
            Node<string> name3 = new Node<string>();
            name3.value = "兔子";
            Node<string> name4 = new Node<string>();
            name4.value = "不是";
            name0.next = name;
            name.next = name2;
            name.next.next = name3;
            name3.head = name2;
            name2.head = name;
            name.head = name0;
            name4.InsertNode(name);//插入到name节点后面
            //name.RemoveNode();//删除name2节点
            name0.Print(name0);
            Console.ReadKey();
        }

    }
}
