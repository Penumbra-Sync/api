using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MareSynchronos.API
{
    public enum MessageSeverity
    {
        Information,
        Warning,
        Error
    }
    public interface IMareHub
    {
        const int ApiVersion = 18;
        const string Path = "/mare";

        Task FilesAbortUpload();
        Task<List<OnlineUserDto>> AdminGetOnlineUsers();
        Task<bool> GroupChangePassword(string gid, string password);
        Task AdminChangeModeratorStatus(string uid, bool isModerator);
        Task GroupChangeOwnership(string gid, string uid);
        Task GroupChangePinned(string gid, string uid, bool isPinned);
        Task<bool> CheckClientHealth();
        Task GroupClear(string gid);
        Task<GroupCreatedDto> GroupCreate();
        Task UserDelete();
        Task FilesDeleteAll();
        Task AdminDeleteBannedUser(BannedUserDto dto);
        Task AdminDeleteForbiddenFile(ForbiddenFileDto dto);
        Task<List<BannedUserDto>> AdminGetBannedUsers();
        Task<List<DownloadFileDto>> FilesGetSizes(List<string> hashes);
        Task<List<ForbiddenFileDto>> AdminGetForbiddenFiles();
        Task<List<BannedGroupUserDto>> GroupGetBannedUsers(string gid);
        Task<List<GroupDto>> GroupsGetAll();
        Task<List<string>> UserGetOnlineCharacters();
        Task<List<ClientPairDto>> UserGetPairedClients();
        Task<List<GroupPairDto>> GroupsGetUsersInGroup(string gid);
        Task GroupBanUser(string gid, string uid, string reason);
        Task GroupChangeInviteState(string gid, bool enabled);
        Task GroupChangePauseState(string gid, bool isPaused);
        Task GroupDelete(string gid);
        Task<bool> GroupJoin(string gid, string password);
        Task GroupLeave(string gid);
        Task GroupRemoveUser(string gid, string uid);
        Task GroupUnbanUser(string gid, string uid);
        Task<List<string>> GroupCreateTempInvite(string gid, int amount);
        Task<ConnectionDto> GetConnectionDto();
        [Obsolete]

        Task<ConnectionDto> Heartbeat(string characterIdentification);
        Task<bool> FilesIsUploadFinished();
        Task UserPushData(CharacterCacheDto characterCache, List<string> visibleCharacterIds);
        Task<List<UploadFileDto>> FilesSend(List<string> fileListHashes);
        Task UserAddPair(string uid);
        Task UserChangePairPauseStatus(string otherUserUid, bool isPaused);
        Task UserRemovePair(string otherUserUid);
        Task GroupSetModerator(string gid, string uid, bool isModerator);
        Task AdminUpdateOrAddBannedUser(BannedUserDto dto);
        Task AdminUpdateOrAddForbiddenFile(ForbiddenFileDto dto);
        Task FilesUploadStreamAsync(string hash, IAsyncEnumerable<byte[]> fileContent);
        Task Client_UserUpdateClientPairs(ClientPairDto clientPairDto);
        Task Client_UpdateSystemInfo(SystemInfoDto systemInfo);
        Task Client_UserReceiveCharacterData(CharacterCacheDto clientPairDto, string characterIdent);
        Task Client_UserChangePairedPlayer(string characterIdent, bool isOnline);
        Task Client_GroupChange(GroupDto groupDto);
        Task Client_GroupUserChange(GroupPairDto groupPairDto);
        Task Client_AdminForcedReconnect();
        Task Client_AdminDeleteBannedUser(BannedUserDto dto);
        Task Client_AdminDeleteForbiddenFile(ForbiddenFileDto dto);
        Task Client_AdminUpdateOrAddBannedUser(BannedUserDto dto);
        Task Client_AdminUpdateOrAddForbiddenFile(ForbiddenFileDto dto);
        Task Client_ReceiveServerMessage(MessageSeverity messageSeverity, string message);
    }

    public interface IMareHubClient : IMareHub
    {
        void OnUserUpdateClientPairs(Action<ClientPairDto> act);
        void OnUpdateSystemInfo(Action<SystemInfoDto> act);
        void OnUserReceiveCharacterData(Action<CharacterCacheDto, string> act);
        void OnUserChangePairedPlayer(Action<string, bool> act);
        void OnGroupChange(Action<GroupDto> act);
        void OnGroupUserChange(Action<GroupPairDto> act);
        void OnAdminForcedReconnect(Action act);
        void OnAdminDeleteBannedUser(Action<BannedUserDto> dto);
        void OnAdminDeleteForbiddenFile(Action<ForbiddenFileDto> act);
        void OnAdminUpdateOrAddBannedUser(Action<BannedUserDto> dto);
        void OnAdminUpdateOrAddForbiddenFile(Action<ForbiddenFileDto> dto);
        void OnReceiveServerMessage(Action<MessageSeverity, string> act);
    }
}