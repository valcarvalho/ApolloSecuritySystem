using System;
using System.Collections.Generic;
using System.Linq;
using Apollo.Security.System.Core.Interface;
using Apollo.Security.System.Core.Model;

namespace Apollo.Security.System.Core.DataLayer
{
    public class SystemCoreRepository : ISystemCoreRepository
    {
      
        public Lock GetLockByRoomNumber(int roomNumber)
        {
            return ApolloData.Locks.FirstOrDefault(loc => loc.RoomNumber == roomNumber);
        }

        public List<Lock> GetAllLocks()
        {
            return ApolloData.Locks;
        }

        public void AddLock(int roomNumber)
        {
            var id = ApolloData.Locks.Any() ? ApolloData.Locks.Last().LockId + 1 : 201;
            ApolloData.Locks.Add(new Lock(id, roomNumber));
        }

        public void AddMemberToLock(Member member, int roomNumber)
        {
            var doorLock = ApolloData.Locks.FirstOrDefault(loc => loc.RoomNumber == roomNumber);
            if(doorLock == null)
                throw new Exception(string.Format("Cannot find lock with room number{0}", roomNumber));
            ApolloData.Locks.First(loc => loc.RoomNumber == roomNumber).Members.Add(member);
        }

        public void RemoveLock(int roomNumber)
        {
            var doorLock = ApolloData.Locks.FirstOrDefault(loc => loc.RoomNumber == roomNumber);
            if (doorLock == null)
                throw new Exception(string.Format("Cannot find lock with room number{0}", roomNumber));
            ApolloData.Locks.Remove(doorLock);
        }

        public Member GetMember(int memberId)
        {
            return ApolloData.Members.FirstOrDefault(member => member.CardKeyNumber == memberId);
        }

        public List<Member> GetAllMember(int memberId)
        {
            return ApolloData.Members;
        }

        public List<Log> GetAllLogs()
        {
            return ApolloLoggingData.Logs;
        }

        public List<Log> GetLogsAfterDate(DateTime dateTime)
        {
            return ApolloLoggingData.Logs.Where(log => log.DateTime.CompareTo(dateTime) >= 0).ToList();
        }

        public List<Log> GetLogsBeforeDate(DateTime dateTime)
        {
            return ApolloLoggingData.Logs.Where(log => log.DateTime.CompareTo(dateTime) < 0).ToList();
        }

        public void WriteLog(DateTime dateTime, int roomNumber, int cardKeyNumber)
        {
            ApolloLoggingData.Logs.Add(new Log
            {
                DateTime = dateTime,
                RoomNumber = roomNumber,
                CardKeyNumber = cardKeyNumber
            
            });
        }
    }
}
