namespace Code.Gameplay.Features.Statuses.Indexing
{
    public struct StatusKey
    {
        public readonly int TargetId;
        public readonly StatusTypeId Type;

        public StatusKey(int targetId, StatusTypeId type)
        {
            TargetId = targetId;
            Type = type;
        }
    }
}