using System;
using System.Collections.Generic;
using Apollo.Security.System.Core.Model;

namespace Apollo.Security.System.Core.Interface
{
    public interface ISystemCoreRepository
    {
        Lock GetLockByRoomNumber(int roomNumber);
        List<Lock> GetAllLocks();
        Member GetMember(int memberId);
        List<Member> GetAllMember(int memberId);
        List<Log> GetAllLogs();
        List<Log> GetLogsAfterDate(DateTime dateTime);
        List<Log> GetLogsBeforeDate(DateTime dateTime);
        void WriteLog(DateTime dateTime, int roomNumber, int cardKeyNumber);
    }
}