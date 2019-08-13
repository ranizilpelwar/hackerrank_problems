using System;
namespace ConsoleApp
{
    public static class JumpingOnTheClouds
    {
        public static int Go(int[] c)
        {
            var jumps = 0;
            if (c.Length == 0) return jumps;
            var index = 0;
            var maxIndex = c.Length - 1;
            while (index < maxIndex)
            {
                index = index + 2;
                if (index > maxIndex)
                {
                    index--;
                }
                if (c[index] == 1)
                {
                    index--;
                }
                jumps++;
            }
            return jumps;
        }

        //return GetPath(clouds).Length;
    

        public static string GetPath(int[] clouds)
        {
            var path = string.Empty;
            if (clouds.Length == 0) return path;
            var index = 0;
            while (index < clouds.Length)
            {
                if (clouds[index] == 0)
                {
                    path += index;
                }
                else
                {
                    path += --index;
                }
                index = index + 2;
            }

            return path.Substring(1);
        }
            

        }
    }
