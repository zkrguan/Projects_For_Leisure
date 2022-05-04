using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learningscript : MonoBehaviour {
   /// <summary>
   /// The first C sharp I am using.
   /// Data type:
   /// 
   /// Float
   ///   You declare a float like this 
   ///      float speed = 5.0f
   /// 
   /// Double 
   ///   you dont need the f any more
   ///      double mana = 15.5;
   ///   unity use the float most 
   ///   
   /// Int:
   ///   same way to declare a variable in C++
   ///  
   /// string: 
   ///   string name = "Kenny"
   ///   You dont need to include the string lib anymore
   ///   
   /// Bool:
   ///   same way to declare a variable in C++
   /// 
   /// char:
   ///   char oneChar = 'a' ;
   ///   barely used in the unity. 
   ///  
   /// </summary>
   // Start is called before the first frame update

   private void Start() {
      //int a = 10;
      //int b = 5;
      //int c = a + b;

      ////two ways to print in the console//
      //print("I want to print this line\n");
      //Debug.Log("this is another line I want to print");

      //// in C sharp you can actually concatenate strings just like in JS by using the + sign//
      //Debug.Log("c is " + a + "\n");

      //// precision is also 
      StartCoroutine(ExecuteSomething());
      // be aware that StartCoroutine("takesStringsToo");
      // also you can use StopCoroutine("takesStringsToo");
      // Like CT defused the bomb //
      // The strings are the function names//

   }

   /// <summary>
   /// Lesson 2 function in C sharp//
   /// 
   /// Just like the other coding language
   /// C sharp has no difference until we learn some special senarios 
   /// declaring function: 
   ///   returning value type (or void) + funciton name + (parameter){
   /// 
   /// }
   /// 
   /// call funciton function name:
   ///   function name (argument);
   /// 
   /// You can also overload the function by using the same function names( just like ad-hoc polymorphism in C++ )
   /// 
   /// 
   /// 
   /// </summary>

 

   // Update is called once per frame
   void Update(){
        
   }

   /// <summary>
   /// Lesson 3 Conditions ( bruh it is exactly the same as C++) 
   /// </summary>

   /// <summary>
   /// Lesson 4 Conditions ( bruh it is exactly the same as C++) 
   /// Case is faster than if and else
   /// </summary>

   /// <summary>
   /// Lesson 5 Loops ( bruh it is exactly the same as C++) 
   /// 
   /// don't really hardcode the loop times in Iteration times
   /// Like you learned from C, avoid the magic number pulling out from no where. 
   /// 
   /// </summary>
   /// 
   /// Now it is something useful
   /// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
   /// Now it is something useful
   /// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
   /// 

   /// <summary>
   /// Lesson 6 Coroutine 
   /// Delayed behaviors. 
   /// Like you dont want to show the boss of the stage right away.
   /// 
   /// 
   /// 
   /// 
   /// </summary>

   // this is something without a coroutine..//
   //void ExecuteSomething(){
   //   Debug.Log("Something is being exectued\n");

   //}


   // Here is something new!
   IEnumerator ExecuteSomething(){
      // yield return new can have a lot of functions can be used for this// 
      // Wait For Seconds are just part of the stuff // 
      yield return new WaitForSeconds(2f);

      Debug.Log("Something is waiting for being executed");
   }
   // in your main code, start funciton //
   //StartCoroutine(ExecuteSomething());
   

}
