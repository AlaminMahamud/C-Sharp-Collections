Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("Cat", 1);
            dic.Add("Dog", 2);
            dic.Add("Rahim",3);
            dic.Add("Sujon", 4);
            foreach (KeyValuePair<string, int> item in dic)
            {
                Console.WriteLine("{0} , {1}",item.Key,item.Value);
            }

            foreach (var i in dic)
            {
                Console.WriteLine(i.Key + " " + i.Value );
            }

            Dictionary<string, int> dic2 = new Dictionary<string, int>()
            {
                { "cat",1},
                { "dog",2 },
                { "sparrow", 3}
            };

            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            // We can assign with the indexer
            dictionary[1] = 2;
            dictionary[2] = 1;
            dictionary[3] = 3; // ReAssign

            // Read With The Indexer
            // An Exception occurs if no element exists
            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary[2]);
                
