using Clean.Domain.Common;

namespace Clean.Examples.CounterWebApp.Domain
{
    public class AppUser : IUser<int>
    {
        public AppUser(int sub, string name)
        {
            Sub = sub;
            Name = name;
        }

        public int Sub { get; set; }
        public string Name { get; set; }
    }
}
