using System.Security.Cryptography.X509Certificates;

namespace Ex07_Class
{
    internal class Cube
    {
        int x, y, z;
        static int countOfInstance = 0;
        public Cube(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            countOfInstance++;
        }
        public int getVolume()
        {
            System.Console.WriteLine($"생성된 큐브의 갯수 : {countOfInstance}");
            return x * y * z;
        }
    }
}