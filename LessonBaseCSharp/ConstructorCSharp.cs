using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonBaseCSharp
{
    public  class ConstructorCSharp
    { 
        public string AgentName;
        public byte Age;
        

        //Create Constructor
        public ConstructorCSharp(string s, byte b)
        {
            AgentName = s;
            Age = b;
            Age = b;
        }

        public void ReWrite()
        {
            Console.WriteLine($"Name Agent = {AgentName} , Age agent  = {Age} ");
        }
    }
}
