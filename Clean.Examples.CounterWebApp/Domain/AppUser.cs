using Clean.Domain.Common;

namespace Clean.Examples.CounterWebApp.Domain
{
    /// <summary>
    /// The app user class
    /// </summary>
    /// <seealso cref="IUser{Int}"/>
    public class AppUser : IUser<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppUser"/> class
        /// </summary>
        /// <param name="sub">The sub</param>
        /// <param name="name">The name</param>
        public AppUser(int sub, string name)
        {
            Sub = sub;
            Name = name;
        }

        /// <summary>
        /// Gets or sets the value of the sub
        /// </summary>
        public int Sub { get; set; }
        /// <summary>
        /// Gets or sets the value of the name
        /// </summary>
        public string Name { get; set; }
    }
}
