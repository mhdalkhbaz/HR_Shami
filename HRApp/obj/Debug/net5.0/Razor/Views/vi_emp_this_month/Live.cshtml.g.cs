#pragma checksum "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfb4550784dc09614b24507cc39a1263682fa52b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_vi_emp_this_month_Live), @"mvc.1.0.view", @"/Views/vi_emp_this_month/Live.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\hr_E\HRApp\HRApp\Views\_ViewImports.cshtml"
using HRApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\hr_E\HRApp\HRApp\Views\_ViewImports.cshtml"
using HRApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfb4550784dc09614b24507cc39a1263682fa52b", @"/Views/vi_emp_this_month/Live.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e169a2b07067aed65c85fcd123d6314d283b878c", @"/Views/_ViewImports.cshtml")]
    public class Views_vi_emp_this_month_Live : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HRApp.Models.ListViewContent>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "vi_emp_this_month", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Live", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <style>


        .green {
            background: green;
        }

        .yellow {
            background: yellow;
        }

        .blue {
            background: blue;
        }

        #chartContainer {
            height: 300px;
        }

        #container {
            height: 300px;
        }


        #container2 {
            height: 300px;
        }


        #container3 {
            height: 300px;
        }


        .highcharts-figure,
        .highcharts-data-table table {
            min-width: 310px;
            max-width: 800px;
            margin: 1em auto;
        }

        .highcharts-data-table table {
            font-family: Verdana, sans-serif;
            border-collapse: collapse;
            border: 1px solid #ebebeb;
            margin: 10px auto;
            text-align: center;
            width: 100%;
            max-width: 500px;
        }

        .highcharts-data-table caption {
            padding: 1em 0;
   ");
            WriteLiteral(@"         font-size: 1.2em;
            color: #555;
        }

        .highcharts-data-table th {
            font-weight: 600;
            padding: 0.5em;
        }

        .highcharts-data-table td,
        .highcharts-data-table th,
        .highcharts-data-table caption {
            padding: 0.5em;
        }

        .highcharts-data-table thead tr,
        .highcharts-data-table tr:nth-child(even) {
            background: #f8f8f8;
        }

        .highcharts-data-table tr:hover {
            background: #f1f7ff;
        }

        svg.highcharts-root {
            width: 100%;
        }

        div#highcharts-9uvgwf3-0.highcharts-container {
            height: 300px;
        }
    </style>

");
            WriteLiteral(@"



<div class=""row"">


    <div class=""col-lg-3   h-100"">
        <h3 class=""text-center"">Shami Cafe</h3>
        <ul class=""list-group"">
            <li class=""list-group-item d-flex justify-content-between align-items-center"">
                عدد الموظفين
                <span class=""badge bg-primary rounded-pill"">");
#nullable restore
#line 102 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                                                       Write(ViewBag.Employees);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n            </li>\r\n            <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n                موظفين الشفت الصباحي\r\n                <span class=\"badge bg-primary rounded-pill\">");
#nullable restore
#line 107 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                                                       Write(ViewBag.EmployeesMorning);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n            </li>\r\n            <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n                موظفين الشفت المسائي\r\n                <span class=\"badge bg-primary rounded-pill\">");
#nullable restore
#line 112 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                                                       Write(ViewBag.EmployeesEvning);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n            </li>\r\n            <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n                المتدربين\r\n                <span class=\"badge bg-primary rounded-pill\">");
#nullable restore
#line 117 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                                                       Write(ViewBag.StartWorkEmp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n            </li>\r\n            <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n                المستقيلين\r\n                <span class=\"badge bg-primary rounded-pill\">");
#nullable restore
#line 122 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                                                       Write(ViewBag.EndWorkEmp);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>

            </li>

            <li class=""list-group-item d-flex justify-content-between align-items-center"">
                نقص الكادر
                <span class=""badge bg-primary rounded-pill"">20 </span>

            </li>
        </ul>
    </div>

    <!-- --------------------- -->

    <div class=""col-lg-3      "">



        <figure class=""highcharts-figure"">
            <div id=""container3""></div>

        </figure>
    </div>

    <!-- --------------------- -->

    <div class=""col-lg-3"">

        <figure class=""highcharts-figure"">

            <div id=""container2""></div>
        </figure>

    </div>


    <script src=""https://code.highcharts.com/highcharts.js""></script>
    <script src=""https://code.highcharts.com/modules/exporting.js""></script>
    <script src=""https://code.highcharts.com/modules/export-data.js""></script>
    <script src=""https://code.highcharts.com/modules/accessibility.js""></script>
    <script src=""https://code.highcharts.com/modu");
            WriteLiteral(@"les/pattern-fill.js""></script>
    <script src=""https://code.highcharts.com/themes/high-contrast-light.js""></script>


    <div class=""col-lg-3      "">

        <figure class=""highcharts-figure"">

            <div id=""container""></div>
        </figure>



    </div>



</div>



    <script>


    Highcharts.chart('container2', {
        chart: {
            type: 'column'
        },
        credits: {
            enabled: false
        },
        title: {
            text: 'إضافي الموظفين خلال الشهر'
        },

        xAxis: {
            type: 'category',
            labels: {
                rotation: -45,
                style: {
                    fontSize: '13px',
                    fontFamily: 'Verdana, sans-serif'
                }
            }
        },
        yAxis: {
            min: 0,
            title: {
                text: ' عدد مرات الاضافي '
            }
        },
        legend: {
            enabled: false
        },
        ");
            WriteLiteral("tooltip: {\r\n            pointFormat: \'</b>\'\r\n        },\r\n        series: [{\r\n            name: \'Population\',\r\n            data: [\r\n\r\n                [ \'");
#nullable restore
#line 223 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
              Write(ViewBag.OverTimeEmp[0].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', ");
#nullable restore
#line 223 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                                             Write(ViewBag.OverTimeEmp[0].OverTime1);

#line default
#line hidden
#nullable disable
            WriteLiteral("],\r\n                [ \'");
#nullable restore
#line 224 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
              Write(ViewBag.OverTimeEmp[1].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', ");
#nullable restore
#line 224 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                                             Write(ViewBag.OverTimeEmp[1].OverTime1);

#line default
#line hidden
#nullable disable
            WriteLiteral("],\r\n                [ \'");
#nullable restore
#line 225 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
              Write(ViewBag.OverTimeEmp[2].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', ");
#nullable restore
#line 225 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                                             Write(ViewBag.OverTimeEmp[2].OverTime1);

#line default
#line hidden
#nullable disable
            WriteLiteral("],\r\n                [ \'");
#nullable restore
#line 226 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
              Write(ViewBag.OverTimeEmp[3].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', ");
#nullable restore
#line 226 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                                             Write(ViewBag.OverTimeEmp[3].OverTime1);

#line default
#line hidden
#nullable disable
            WriteLiteral("],\r\n                [ \'");
#nullable restore
#line 227 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
              Write(ViewBag.OverTimeEmp[4].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', ");
#nullable restore
#line 227 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                                             Write(ViewBag.OverTimeEmp[4].OverTime1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"],


        ],
        dataLabels: {
            enabled: true,
            rotation: -90,
            color: '#FFFF11',
            align: 'right',
            //format: '{point.y:.1f}', // one decimal
            y: 10, // 10 pixels down from the top
            style: {
                fontSize: '13px',
                fontFamily: 'Verdana, sans-serif'
            }
        }
        }]
        });



        //----------------------------------------------------------------

    Highcharts.chart('container', {
        chart: {
            type: 'column'
        },
        credits: {
            enabled: false
        },
        title: {
            text: 'تأخر الموظفين خلال الشهر'
        },

        xAxis: {
            type: 'category',
            labels: {
                rotation: -45,
                style: {
                    fontSize: '13px',
                    fontFamily: 'Verdana, sans-serif'
                }
            }
        },
        yAxis");
            WriteLiteral(@": {
            min: 0,
            title: {
                text: '   عدد مرات التأخير'
            }
        },
        legend: {
            enabled: false
        },
        tooltip: {
            pointFormat: '</b>'
        },
        series: [{
            name: 'Population',
            data: [

                [ '");
#nullable restore
#line 287 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
              Write(ViewBag.LateEmp[0].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', ");
#nullable restore
#line 287 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                                         Write(ViewBag.LateEmp[0].LateHour);

#line default
#line hidden
#nullable disable
            WriteLiteral("],\r\n                [ \'");
#nullable restore
#line 288 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
              Write(ViewBag.LateEmp[1].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', ");
#nullable restore
#line 288 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                                         Write(ViewBag.LateEmp[1].LateHour);

#line default
#line hidden
#nullable disable
            WriteLiteral("],\r\n                [ \'");
#nullable restore
#line 289 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
              Write(ViewBag.LateEmp[2].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', ");
#nullable restore
#line 289 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                                         Write(ViewBag.LateEmp[2].LateHour);

#line default
#line hidden
#nullable disable
            WriteLiteral("],\r\n                [ \'");
#nullable restore
#line 290 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
              Write(ViewBag.LateEmp[3].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', ");
#nullable restore
#line 290 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                                         Write(ViewBag.LateEmp[3].LateHour);

#line default
#line hidden
#nullable disable
            WriteLiteral("],\r\n                [ \'");
#nullable restore
#line 291 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
              Write(ViewBag.LateEmp[4].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', ");
#nullable restore
#line 291 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                                         Write(ViewBag.LateEmp[4].LateHour);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"],


        ],
        dataLabels: {
            enabled: true,
            rotation: -90,
            color: '#ff0000',
            align: 'right',
            //format: '{point.y:.1f}', // one decimal
            y: 10, // 10 pixels down from the top
            style: {
                fontSize: '13px',
                fontFamily: 'Verdana, sans-serif'
            }
        }
        }]
        });





        //----------------------------------------------bar chrt



                var clrs = Highcharts.getOptions().colors;
        var pieColors = [clrs[2], clrs[0], clrs[3], clrs[1], clrs[4]];

        // Get a default pattern, but using the pieColors above.
        // The i-argument refers to which default pattern to use
        function getPattern(i) {
          return {
            pattern: Highcharts.merge(Highcharts.patterns[i], {
              color: pieColors[i]
            })
          };
        }

        // Get 5 patterns
        var patterns = [0, 1");
            WriteLiteral(@", 2, 3, 4].map(getPattern);

        var chart = Highcharts.chart('container3', {
          chart: {
            type: 'pie'
            },
            credits: {
                enabled: false
            },
          title: {
            text: 'دوام الموظفين'
          },



          colors: patterns,

          tooltip: {
            //valueSuffix: '%',
            borderColor: '#8ae'
          },

          //plotOptions: {
          //  series: {
          //    dataLabels: {
          //      enabled: true,
          //      connectorColor: '#777',
          //      //format: '<b>{point.name}</b>: {point.percentage:.1f} %'
          //    },
          //    point: {
          //      events: {
          //        click: function () {
          //          window.location.href = this.website;
          //        }
          //      }
          //    },
          //    cursor: 'pointer',
          //    borderWidth: 3
          //  }
          //},

          seri");
            WriteLiteral("es: [{\r\n            //name: \'Screen reader usage\',\r\n            data: [{\r\n              name: \'الشفت الصباحي\',\r\n              y: ");
#nullable restore
#line 377 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
            Write(ViewBag.EmployeesMorning);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n\r\n            },\r\n                {\r\n                    name: \'الشفت المسائي\',\r\n                    y: ");
#nullable restore
#line 382 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                  Write(ViewBag.EmployeesEvning);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                }
                ,
                {
                    name: '  نقص الكادر ' ,
                    y: 20,
                }
            ]
          }],

          responsive: {
            rules: [{   
              condition: {
                maxWidth: 500
              },
              //chartOptions: {
              //  plotOptions: {
              //    series: {
              //      dataLabels: {
              //        format: '<b>{point.name}</b>'
              //      }
              //    }
              //  }
              //}
            }]
          }
        });

        //// Toggle patterns enabled
        //document.getElementById('patterns-enabled').onclick = function () {
        //  chart.update({
        //    colors: this.checked ? patterns : pieColors
        //  });
        //        };

    </script>

    </div>

");
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfb4550784dc09614b24507cc39a1263682fa52b20868", async() => {
                WriteLiteral("\r\n        <p>\r\n\r\n            Date Day\r\n            <input type=\"date\" name=\"SearchString\">\r\n            <input type=\"submit\" value=\"Filter\" />\r\n        </p>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 436 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
         foreach (var item in Model.ListOfViewContent)
        {



            IList<ViewContent> valuesList = item.Value.Where(w => w.depId == 2).ToList();

            IList<ViewContent> valuesListHQ = item.Value.Where(w => w.depId == 1).ToList();

            valuesList = valuesList.OrderBy(e => e.InHour).ToList();



            var valuesListFirst = valuesList.Select(m => m.Time_InHour).FirstOrDefault();

            //Console.WriteLine(valuesListFirst);
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-sm-12 col-md-6 col-lg-2 content_p\"");
            BeginWriteAttribute("style", " style=\"", 11692, "\"", 11700, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
            WriteLiteral("                <div class=\"col-sm-12 col-xs-6 col-lg-6  goLeft\" style=\"font-size: 12px;font-family: monospace; margin: 0\">\r\n                    <p> ");
#nullable restore
#line 461 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                   Write(valuesListFirst);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </div>\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n                <div class=\"Open col-sm-12 col-xs-6 col-lg-6\" style=\" padding: 0;\">\r\n                    <tr>\r\n                        <td>\r\n                            <h5 style=\"color: #1e0042cc;\">     ");
#nullable restore
#line 472 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                                                          Write(Html.DisplayFor(modelItem => item.Key));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </h5>\r\n                        </td>\r\n                    </tr>\r\n                </div>\r\n\r\n\r\n\r\n");
            WriteLiteral("                <div class=\"scrol\">\r\n\r\n                    <table class=\"table\">\r\n\r\n");
#nullable restore
#line 484 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                         foreach (var raw in valuesList)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tbody>\r\n                            <td>\r\n                                ");
#nullable restore
#line 488 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                           Write(Html.DisplayFor(modelItem => raw.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 491 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                           Write(Html.DisplayFor(modelItem => raw.Time_InHour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 495 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                           Write(Html.DisplayFor(modelItem => raw.Time_OutHour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            </tbody>\r\n");
#nullable restore
#line 498 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 503 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Live.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HRApp.Models.ListViewContent> Html { get; private set; }
    }
}
#pragma warning restore 1591
