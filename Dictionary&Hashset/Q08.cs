using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Dictionary_Hashset
{
    /*
        Dynamic Skill Matching
        Problem: Match a candidate’s skills to a job’s required skills.

        Input:
        candidateSkills = { "C#", "SQL", "JavaScript" }
        jobRequirements = { "C#", "JavaScript", "React" }

        Output: Matching Skills: C#, JavaScript
     */
    public class Q08
    {
        public static void Question()
        {
          /*  string[] candidateSkills = ["C#", "SQL", "JavaScript"];
            string[] jobRequirements = ["C#", "JavaScript", "React"];
            HashSet<string> hs = new HashSet<string>(jobRequirements);
            List<string> result = new List<string>();   

            foreach (var item in candidateSkills)
               if(hs.Contains(item))  result.Add(item);

            Console.WriteLine($"Matching Skills: {string.Join(" , ", result)}");*/

            HashSet<string> candidateSkills = new HashSet<string> { "C#", "SQL", "JavaScript" };
            HashSet<string> jobRequirements = new HashSet<string> { "C#", "JavaScript", "React" };

            candidateSkills.IntersectWith(jobRequirements);

            Console.WriteLine("Matching Skills: " + string.Join(", ", candidateSkills));

        }


    }
}
