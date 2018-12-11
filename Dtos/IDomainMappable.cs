namespace no_more_typecasting.Dtos
{
    public interface IDomainMappable<TDomain, TDependency>
    {
         TDomain ToDomain(TDependency dependencies);
    }
}