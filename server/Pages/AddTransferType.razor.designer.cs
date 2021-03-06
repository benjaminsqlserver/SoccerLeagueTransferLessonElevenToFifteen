﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using SoccerLeagueTransferApp.Models.ConData;
using Microsoft.EntityFrameworkCore;

namespace SoccerLeagueTransferApp.Pages
{
    public partial class AddTransferTypeComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(() => { StateHasChanged(); });
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected ConDataService ConData { get; set; }

        SoccerLeagueTransferApp.Models.ConData.TransferType _transfertype;
        protected SoccerLeagueTransferApp.Models.ConData.TransferType transfertype
        {
            get
            {
                return _transfertype;
            }
            set
            {
                if (!object.Equals(_transfertype, value))
                {
                    _transfertype = value;
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }

        protected async System.Threading.Tasks.Task Load()
        {
            await CheckUserStatus();

            transfertype = new SoccerLeagueTransferApp.Models.ConData.TransferType(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(SoccerLeagueTransferApp.Models.ConData.TransferType args)
        {
            try
            {
                var conDataCreateTransferTypeResult = await ConData.CreateTransferType(transfertype);
                DialogService.Close(transfertype);
            }
            catch (System.Exception conDataCreateTransferTypeException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TransferType!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
