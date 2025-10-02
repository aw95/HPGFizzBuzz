using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPGFizzBuzzProject.Services.Interfaces
{
    public interface IFizzBuzzService
    {
        public List<string> GetFizzBuzzOutput(List<int> numbers);
    }
}
