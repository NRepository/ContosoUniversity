namespace ContosoUniversity.Web.Core.Repository.Interceptors
{
    using Domain.Core.Repository;
    using NRepository.Core.Command;
    using System;

    public class TrackedEntitiesModifyCommandInterceptor : IModifyCommandInterceptor
    {
        public void Modify<T>(ICommandRepository repository, Action<T> modifyAction, T entity) where T : class
        {
            if (typeof(ITrackedEntity).IsAssignableFrom(typeof(T)))
            {
                var trackedEntity = (ITrackedEntity)entity;
                trackedEntity.ModifiedBy = CurrentPrincipalHelper.Name;
                trackedEntity.ModifiedOn = DateTime.Now;
            }

            modifyAction(entity);
        }
    }
}
