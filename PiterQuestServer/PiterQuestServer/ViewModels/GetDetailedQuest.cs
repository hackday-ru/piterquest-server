using System.Collections.Generic;

namespace Quests.ViewModels
{
  public class GetDetailedQuest
  {
    public GetAllQuests info { get; set; }
    public IEnumerable<PointExport> points { get; set; }
  }
}
