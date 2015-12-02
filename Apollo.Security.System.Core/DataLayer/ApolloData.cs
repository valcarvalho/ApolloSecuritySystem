using System.Collections.Generic;
using Apollo.Security.System.Core.Model;

namespace Apollo.Security.System.Core.DataLayer
{
    internal static class ApolloData
    {
        private static readonly List<Lock> _locks = new List<Lock>();
        private static readonly List<Member> _members = new List<Member>();

        static ApolloData()
        {
            Locks.AddRange(new List<Lock>
                {
                    new Lock(250, 201 )
                    {
                        Members = new List<Member>
                        {
                            new Member(801, true),
                            new Member(802, false),
                            new Member(803, false),
                            new Member(804, false)
                        }
                    },

                    new Lock(251, 303)
                    {
                        Members = new List<Member>
                        {
                           new Member(801, true),
                           new Member(804, false)
                        }
                    },

                });

            Members.AddRange(new List<Member>
                {
                    new Member(801, true),
                    new Member(802, false),
                    new Member(803, false),
                    new Member(804, false)
                });
        }


        public static List<Member> Members
        {
            get { return _members; }
        }

        public static List<Lock> Locks
        {
            get { return _locks; }
        }

      
    }
}
