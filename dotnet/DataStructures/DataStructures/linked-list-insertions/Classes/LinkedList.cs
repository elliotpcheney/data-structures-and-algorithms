using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Classes
{
  public class LinkedList<T>
  {
    public virtual Node<T> Head { get; set; }

    //LinkedList myList = new LinkedList();
    public LinkedList() //constructor
    {
    }

    public string Print() //prints out all nodes that are present.
    {
      Node<T> current = Head;
      string write = "";
      while (current != null)
      {

        write = $"( {current.Value} ) -> ";
        Console.Write(write);
        current = current.Next;
      }
      Console.Write("NULL\n");
      write = write + "NULL";
      return write;
    }


    public void Append(T val)
    {
      Node<T> node = new Node<T>(val);
      if (Head == null)
      {
        Head = node;
        return;
      }

      Node<T> current = Head;
      while (current.Next != null)
      {
        current = current.Next;
      }
      current.Next = node;
    }

    public void InsertAfter(T target, T newVal)
    {
      Node<T> newNode = new Node<T>(newVal);
      Node<T> current = Head;
      bool end = false;
      // iterates over the linkedlist
      while (end == false)
      {
        // if current node is equal to target
        if (current.Value == target)
        {
          // Store original next value
          Node oldNext = current.Next;
          // Set current Next value to the new Node
          current.Next = newNode;
          // Set the new Node's value to the original next value of target, to contiue linked list
          newNode.Next = oldNext;
          return;
        }
        else if (current.Next == null)
        {
          end = true;
        }
        current = current.Next;
      }
      throw new Exception("Could not recognize given node value.");
    }
    public void InsertBefore(int target, int newVal)
    {
      Node newNode = new Node(newVal);
      Node current = Head;
      if (current.Value == target)
      {
        Insert(newVal);
        return;
      }
      while (current.Value != target)
      {
        // if current next value is equal to target
        if (current.Next.Value == target)
        {
          Node oldNext = current.Next;
          // set current next to the new node
          current.Next = newNode;
          // set new node next to target (links the list back together)
          newNode.Next = oldNext;
          return;
        }
        current = current.Next; // keep searching until current is the target node
      }
      throw new Exception("Could not recognize given node value.");
    }


    public void insertAfter(Node target, int newVal)
    {
      Node newNode = new Node(newVal);
      Node current = Head;
      // iterates over the linkedlist
      while (current != target)
      {
        // if current node is equal to target
        if (current == target)
        {
          // Store original next value
          Node oldNext = current.Next;
          // Set current Next value to the new Node
          current.Next = newNode;
          // Set the new Node's value to the original next value of target, to contiue linked list
          newNode.Next = oldNext;
        }
        current = current.Next;
      }
      throw new Exception("Could not recognize given node value.");
    }

    public bool Includes(int val)
    {
      Node current = Head; // set variable current to Head
      while (current != null)
      {
        if (current.Value == val) return true;
        current = current.Next;
      }
      return false;
    }

    public int KthFromEnd(int k)
    {
      Node current = Head; // starting value for current.

      if (Head == null) return -1;
      int i = 0;
      while (current != null)
      {
        while (i <= k)
        {
          i++;
        }
      }
      return 0;
    }

    public void Insert(int val)
    {
      Node node = new Node(val);
      if (Head != null)
      { // if the head value in the Linked List already exists, the next node is set to head.
        node.Next = Head; // ensuring that the new node value is put at the end of the list
      }
      Head = node; // set head value to the newly created node.
    }

    public void ReverseLinkedList(LinkedList ll)
    {

      // Create a new linked list that we will store reversed values insid
      LinkedList newList = new LinkedList();

      // Set the "current" Node to the head of original linked list
      Node current = ll.Head;
      while (current != null)
      {
        // Insert a node into the new linked list with the value of current(from original)
        newList.Insert(current.Value);
        //NOW current from original linked list is same value as head in new list
        current = current.Next;
      }
    }
  }
}
