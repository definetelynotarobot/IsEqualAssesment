var firstStrings = new List<string> { "aaa", "abbc", "zyz" };
var secondStrings = new List<string> { "bbb", "cccc", "zyx" };
var res = canBeEqualized(firstStrings, secondStrings);


foreach (var item in res)
{
    Console.WriteLine(item);
}


List<string> canBeEqualized(List<string> firstStrings, List<string> secondStrings)
{
    var result = new List<string>();
    for (int i = 0; i < firstStrings.Count; i++)
    {
        string s1 = firstStrings[i];
        string s2 = secondStrings[i];
        if (s1.Length != s2.Length)
        {
            result.Add("NO");
            continue;
        }
        if (s1 == s2)
            result.Add("YES");
        {
            for (int j = 0; j < s1.Length; j++)
            {
                if (s1[j] != s2[j])
                {
                    var temp = s2.Replace(s2[j], s1[j]);
                    if (s1 == temp)
                        result.Add("YES");
                        

                    temp = s1.Replace(s1[j], s2[j]);
                    if (s2 == temp)
                        result.Add("NO");
                        
                }

            }
            //Ekstra NO eklediği ve gerek duyulmadığı için kaldırdım.
           // result.Add("NO");

        }
    
    }
    return result;
}

/*
string isBeEqualized(string s1, string s2)
{
    
}*/
