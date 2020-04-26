using System.Collections.Generic;
using System.Linq;

namespace TreinamentoLinq.ApiDados.ViewModels.RetornoPadrao
{
    public class ModelTable<TViewModel> : ModelPadrao where TViewModel : class 
    {
        public IEnumerable<TViewModel> Table { get; set; }
        public int Count
        {
            get => this.Table.Count();
        }
    }
}
