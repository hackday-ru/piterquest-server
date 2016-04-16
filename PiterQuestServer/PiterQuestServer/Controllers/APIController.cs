using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Quests.Models;
using Quests.ViewModels;

namespace Quests.Controllers
{
  public class APIController : ApiController
  {
    private QuestDBEntities1 context;

    public APIController()
    {
      context = new QuestDBEntities1();
    }

    [Route("api/GetAllQuests")]
    [HttpGet]
    public IEnumerable<GetAllQuests> GetAllQuests()
      => context.Quests.Select(x => new GetAllQuests
      {
        description = x.Desription,
        id = x.QuestID,
        imageUrl = x.ImageUrl,
        name = x.Name
      });

    [Route("api/GetDetailedQuest")]
    [HttpGet]
    public GetDetailedQuest GetDetailedQuest(int id)
    {
      // нашли квест в базе
      var quest = context.Quests.FirstOrDefault(x => x.QuestID == id);

      if (quest == null)
        return null;

      else
      {
        // нашли его точки
        var points = context.Points.Where(x => x.QuestID == id);

        return new GetDetailedQuest
        {
          info = new GetAllQuests
          {
            description = quest.Desription,
            id = quest.QuestID,
            imageUrl = quest.ImageUrl,
            name = quest.Name
          },
          points = points.Select(x => new PointExport
          {
            X = x.X,
            hasGpsHint = x.HasLocationHint.Value,
            hintText = x.HintText,
            hintImageUrl = x.HintImageUrl,
            solution = x.Answer,
            taskImageUrl = x.TaskImageUrl,
            taskText = x.TaskText,
            Y = x.Y
          })
        };
      }
    }


  }
}
