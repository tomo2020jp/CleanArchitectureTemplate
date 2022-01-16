using CleanArchitectureTemplate.Core.ProjectAggregate;
using CleanArchitectureTemplate.SharedKernel;

namespace CleanArchitectureTemplate.Core.ProjectAggregate.Events;

public class ToDoItemCompletedEvent : BaseDomainEvent
{
  public ToDoItem CompletedItem { get; set; }

  public ToDoItemCompletedEvent(ToDoItem completedItem)
  {
    CompletedItem = completedItem;
  }
}
