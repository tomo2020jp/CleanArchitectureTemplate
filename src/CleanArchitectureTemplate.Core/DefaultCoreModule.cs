using Autofac;
using CleanArchitectureTemplate.Core.Interfaces;
using CleanArchitectureTemplate.Core.Services;

namespace CleanArchitectureTemplate.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
