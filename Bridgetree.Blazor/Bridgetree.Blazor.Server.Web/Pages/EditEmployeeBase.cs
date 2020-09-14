using Bridgetree.Blazor.Models;
using Bridgetree.Blazor.Server.Web.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bridgetree.Blazor.Server.Web.Pages
{
    public class EditEmployeeBase : ComponentBase
    {
        public string DepartmentId { get; set; }
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public string PageHeaderText { get; set; }
        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public List<Department> Departments { get; set; } =
          new List<Department>();

        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {


            int.TryParse(Id, out int employeeId);

            if (employeeId != 0)
            {
                PageHeaderText = "Edit Employee";
                Employee = await EmployeeService.GetEmployee(int.Parse(Id));
            }
            else
            {
                PageHeaderText = "Create Employee";
                Employee = new Employee
                {
                    DepartmentId = 1,
                    DateOfBrith = DateTime.Now,
                };
            }

            Departments = (await DepartmentService.GetDepartments()).ToList();
            DepartmentId = Employee.DepartmentId.ToString();

        }


        protected async Task HandleValidSubmit()
        {
            Employee result = null;
            Employee.DepartmentId = Convert.ToInt32(DepartmentId);
            if (Employee.EmployeeId != 0)
            {

                result = await EmployeeService.UpdateEmployee(Employee);
            }
            else
            {
                result = await EmployeeService.CreateEmployee(Employee);
            }
            if (result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }


    }
}
