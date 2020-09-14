using Bridgetree.Blazor.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bridgetree.Blazor.Server.Web.Pages
{
    public class DisplayEmployeeBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<Employee> Employees { get; set; }

        [Parameter]
        public EventCallback<int> OnEmployeeSelection { get; set; }

        protected async Task CheckBoxChanged()
        {
            currentCount++;
            await OnEmployeeSelection.InvokeAsync(currentCount);
        }
        private int currentCount = 0;


    }
}
