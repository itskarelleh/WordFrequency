// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WordFrequency.Shared
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\T440\Source\Repos\karellehofler\word-frequency\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\T440\Source\Repos\karellehofler\word-frequency\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\T440\Source\Repos\karellehofler\word-frequency\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\T440\Source\Repos\karellehofler\word-frequency\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\T440\Source\Repos\karellehofler\word-frequency\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\T440\Source\Repos\karellehofler\word-frequency\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\T440\Source\Repos\karellehofler\word-frequency\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\T440\Source\Repos\karellehofler\word-frequency\_Imports.razor"
using WordFrequency;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\T440\Source\Repos\karellehofler\word-frequency\Shared\TranslatorTable.razor"
using WordFrequency.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\T440\Source\Repos\karellehofler\word-frequency\Shared\TranslatorTable.razor"
using WordFrequency.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\T440\Source\Repos\karellehofler\word-frequency\Shared\TranslatorTable.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\T440\Source\Repos\karellehofler\word-frequency\Shared\TranslatorTable.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    public partial class TranslatorTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\T440\Source\Repos\karellehofler\word-frequency\Shared\TranslatorTable.razor"
       

    [Parameter]
    public string TextInput { get; set; }
    public List<Word> words { get; set; } = new List<Word>();

    public void convertInputToWordList()
    {
        string str = Regex.Replace(TextInput, @"[^\w\s]", string.Empty);

        string[] arr = str.Split(" ");
        arr = arr.Select(s => s.ToLowerInvariant()).ToArray();
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
