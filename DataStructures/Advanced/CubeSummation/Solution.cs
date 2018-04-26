using System;
using System.Collections.Generic;

namespace CubeSummation
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int[] nm = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int n = nm[0];
                int m = nm[1];

                Dictionary<int, Update> updates = new Dictionary<int, Update>();

                for (int j = 0; j < m; j++)
                {
                    string[] operation = Console.ReadLine().Split(' ');

                    if (operation[0] == "UPDATE")
                    {
                        Update currentUpdate = new Update(int.Parse(operation[1]), int.Parse(operation[2]), int.Parse(operation[3]), int.Parse(operation[4]));
                        int currentKey = currentUpdate.GetHashCode();
                        bool overridden = false;

                        while (updates.ContainsKey(currentKey))
                        {
                            if(currentUpdate.Position == updates[currentKey].Position)
                            {
                                updates[currentKey] = currentUpdate;
                                overridden = true;
                            }

                            currentKey++;
                        }

                        if (!overridden)
                        {
                            updates.Add(currentKey, currentUpdate);
                        }
                    }
                    else if (operation[0] == "QUERY")
                    {
                        long sum = 0;

                        Query query = new Query(int.Parse(operation[1]), int.Parse(operation[2]), int.Parse(operation[3]), 
                                                int.Parse(operation[4]), int.Parse(operation[5]), int.Parse(operation[6]));

                        foreach (KeyValuePair<int, Update> update in updates)
                        {
                            if((update.Value.Position.X >= query.LowerBound.X) && (update.Value.Position.X <= query.UpperBound.X) &&
                               (update.Value.Position.Y >= query.LowerBound.Y) && (update.Value.Position.Y <= query.UpperBound.Y) &&
                               (update.Value.Position.Z >= query.LowerBound.Z) && (update.Value.Position.Z <= query.UpperBound.Z))
                            {
                                sum += update.Value.W;
                            }
                        }

                        Console.WriteLine(sum);
                    }
                }
            }
        }

        struct Update
        {
            public Update(int x, int y, int z, int w)
            {
                Position = new Vector3
                {
                    X = x,
                    Y = y,
                    Z = z
                };

                W = w;
            }

            public Vector3 Position { get; set; }

            public int W { get; set; }

            
            public override int GetHashCode()
            {
                return Position.GetHashCode();
            }
        }

        struct Query
        {
            public Query(int x1, int y1, int z1, int x2, int y2, int z2)
            {
                LowerBound = new Vector3
                {
                    X = x1,
                    Y = y1,
                    Z = z1
                };

                UpperBound = new Vector3
                {
                    X = x2,
                    Y = y2,
                    Z = z2
                };
            }

            public Vector3 LowerBound { get; set; }
            public Vector3 UpperBound { get; set; }
        }

        struct Vector3
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }

            public static bool operator ==(Vector3 a, Vector3 b)
            {
                return (a.X == b.X) && (a.Y == b.Y) && (a.Z == b.Z);
            }

            public static bool operator !=(Vector3 a, Vector3 b)
            {
                return a != b;
            }

            public override int GetHashCode()
            {
                return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                Vector3 a = (Vector3)obj;
                return X.Equals(a.X) && Y.Equals(a.Y) && Z.Equals(a.Z);
            }
        }
    }
}
