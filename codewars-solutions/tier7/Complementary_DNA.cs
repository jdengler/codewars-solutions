//https://www.codewars.com/kata/554e4a2f232cdd87d9000038

public class DnaStrand
    {
        public static string MakeComplement(string dna)
        {
            //Your code
            string comp = "";

            foreach(char c in dna)
            {
              switch(c)
              {
                case 'A': comp += 'T'; break;
                case 'T': comp += 'A'; break;
                case 'C': comp += 'G'; break;
                case 'G': comp += 'C'; break;
              }
            }
            return comp;
        }
    }
