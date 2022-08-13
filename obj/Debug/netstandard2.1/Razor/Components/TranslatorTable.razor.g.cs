#pragma checksum "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c53e05f65d2b09700cc44785959f763cb595148"
// <auto-generated/>
#pragma warning disable 1591
namespace WordFrequency.Components
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using WordFrequency;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using WordFrequency.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
using WordFrequency.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
using WordFrequency.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    public partial class TranslatorTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "my-auto w-full h-3/4 flex flex-col items-center");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "m-auto");
            __builder.AddMarkupContent(5, "  \r\n        ");
            __builder.OpenElement(6, "h3");
            __builder.AddAttribute(7, "class", "m-auto text-center text-3xl font-semibold font-sans text-white");
#nullable restore
#line 8 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
__builder.AddContent(8, words.Count == 0 ?
            "Time to Translate some Words! 📝" : "Results");

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "h4");
            __builder.AddAttribute(12, "class", "m-auto text-center text-2xl font-sans text-white");
#nullable restore
#line 11 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
__builder.AddContent(13, words.Count == 0 ? "Write or copy + paste text into the textbox" : null);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n");
#nullable restore
#line 14 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
     if (words.Count != 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "mx-auto h-2/3 w-1/2 sm:w-2/3 overflow-auto");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "table");
            __builder.AddAttribute(21, "class", "h-1/2 sm:h-full sm:h-auto table-auto w-full bg-white overflow-auto");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddMarkupContent(23, "<thead>\r\n                    <tr>\r\n                        <th>word</th>\r\n                        <th>frequency</th>\r\n                    </tr>\r\n                </thead>\r\n                ");
            __builder.OpenElement(24, "tbody");
            __builder.AddAttribute(25, "class", "overflow-y-auto h-full");
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 25 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
                     foreach (var word in words)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                        ");
            __builder.OpenElement(28, "tr");
            __builder.SetKey(
#nullable restore
#line 27 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
                                 word

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.OpenElement(30, "td");
            __builder.AddAttribute(31, "class", "indent-3");
#nullable restore
#line 28 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
__builder.AddContent(32, word.Value);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.OpenElement(34, "td");
            __builder.AddAttribute(35, "class", "text-center");
#nullable restore
#line 29 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
__builder.AddContent(36, word.Frequency);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 31 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 35 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
       

    [Parameter]
    public string TextInput { get; set; }
    public List<Word> words { get; set; } = new List<Word>();

    public void convertInputToWordList()
    {
        string str = Regex.Replace(TextInput, @"[^\w\s]", string.Empty);

        string[] arr = str.Split(" ");

        Array.Sort(arr, StringComparer.Ordinal);

        int next = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            i = next;
            int count = 1;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] == arr[i])
                {
                    count++;
                }

                if (arr[j] != arr[i])
                {
                    next = j;
                    break;
                }
            }

            Word curr = new Word(arr[i], count);

            words.Add(curr);
        }

        words = words.OrderByDescending(w => w.Frequency).ToList();

        //StateHasChanged();
    }
     
    public void resetTable()
    {
        words = new List<Word>();
        StateHasChanged();
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();

        words = new List<Word>();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
