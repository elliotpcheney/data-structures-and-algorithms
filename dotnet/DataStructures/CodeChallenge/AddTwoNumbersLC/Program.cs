using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeChallenge18.Classes;

namespace AddTwoNumbersLC
{
  class Node<T>
  {
    public int val;

    public Node<T> next;

    public Node(int val=0, Node<T> next=null)
    {
      this.val = val;
      this.next = next;
    }
  }
    class Program
    {
        static void Main(string[] args)
        {
          Node<int> node1 = new();
          Node<int> node2 = new();
          Node<int> secondNode = new();
          Node<int> secondNode2 = new();

          Node<int> thirdNode = new();
          Node<int> thirdNode2 = new();

      Node<int> fourthNode = new();
      Node<int> fourthNode2 = new();

      Node<int> fifthNode2 = new();
      Node<int> sixthNode2 = new();
      Node<int> seventhNode2 = new();

          Node<int> originalNode1 = node1;
          node1.val = 9;

          node1.next = secondNode;
          node1.next.val = 9;
          node1 = node1.next;

          node1.next = thirdNode;
          node1.next.val = 9;
          node1 = node1.next;

          node1.next = fourthNode;
      node1.next.val = 9;

          Node<int> originalNode2 = node2;
          node2.val = 9;

          node2.next = secondNode2;
          node2.next.val = 9;
          node2 = node2.next;

          node2.next = thirdNode2;
          node2.next.val = 9;
          node2 = node2.next;

          node2.next = fourthNode2;
          node2.next.val = 9;
          node2 = node2.next;

          node2.next = fifthNode2;
          node2.next.val = 9;
          node2 = node2.next;

          node2.next = sixthNode2;
          node2.next.val = 9;
          node2 = node2.next;

          node2.next = seventhNode2;
          node2.next.val = 9;

          Node<int> ans = AddTwoNumbers(originalNode1, originalNode2);
          while(ans != null)
          {
            Console.WriteLine(ans.val);
            ans = ans.next;
          }
        }


    public static Node<int> AddTwoNumbers(Node<int> node, Node<int> node2)
    {
      int carryOver = 0;
      Node<int> sumNode = new();
      Node<int> firstNode = sumNode;

      // BELOW CODE CAN BE REFACTORED TO HAVE SINGLE FUNCTION
      // While both node 1 and 2's next are not null..
      do
      {
        // If either side is null..
        if (node == null)
        {
          while (node2 != null)
          {
            sumNode.val = node2.val + carryOver;
            carryOver = 0;
            if ( sumNode.val >= 10)
            {
              carryOver = Convert.ToInt32(Math.Floor(Convert.ToDouble(sumNode.val / 10)));
              // round local sum
              sumNode.val = Convert.ToInt32(Math.Floor(Convert.ToDouble(sumNode.val % 10)));
            }
            node2 = node2.next;
            if (node2 != null)
            {
              sumNode.next = new Node<int>();
              sumNode = sumNode.next;
            }
          }
        }

        else if (node2 == null)
        {
          while (node != null)
          {
            sumNode.val = node.val + carryOver;
            carryOver = 0;
            if ( sumNode.val >= 10)
            {
              carryOver = Convert.ToInt32(Math.Floor(Convert.ToDouble(sumNode.val/ 10)));
              // round local sum
              sumNode.val = Convert.ToInt32(Math.Floor(Convert.ToDouble(sumNode.val % 10)));
            }
            node = node.next;
            // If the next node is not null, initialize a brand new node.
            if (node != null)
            {
              sumNode.next = new Node<int>();
              sumNode = sumNode.next;
            }
          }
        }

        else
        {
          double localSum = node.val + node2.val;

          // If there is a carryOver value, add it to the local sum now.
          localSum += carryOver;
          // Reset carryOver val as it has served its purpose.
          carryOver = 0;

          // If any amount is greater than or equal to 10..
          if (localSum >= 10)
          {
            // Make the carryover value the mod of 10.
            carryOver = Convert.ToInt32(Math.Floor(localSum % 10)); // reversed this with local sum (the mod operation..needs a test)
            // round local sum
            localSum = Math.Floor(localSum / 10);
          }

          sumNode.val = Convert.ToInt32(localSum);

          // Increment both linked lists and the index number
          node = node.next;
          node2 = node2.next;
          if (node != null || node2 != null)
          {
            sumNode.next = new Node<int>();
            sumNode = sumNode.next;
          }
        }
      } while (node != null || node2 != null);

      //If there is a leftover caryover from the last value in linked list pair, account for it and add to sum
      if (carryOver != 0)
      {
        sumNode.next = new();
        sumNode.next.val = carryOver;
      }
      return firstNode;
    }
    // init result list
    // init carryover value

    // while either is not null
    //    check l1 whether it is null
    //        if null the value to sum is "0"
    //        if not null grab the value and advance list ptr

    //    do the same for l2 as above for l1^
    //
    //    sum the l1 and l2 values and previous carryover
    //    store the "ones" value of the result in the "result" list
    //    store the carryover (and/or reset carryover to zero)
    //    advance the "result" list ptr
    //
    // return result
  }
}
