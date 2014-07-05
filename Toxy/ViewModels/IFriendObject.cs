﻿using System;
using System.Windows.Documents;
using SharpTox.Core;

namespace Toxy.ViewModels
{
    public interface IFriendObject : IChatObject
    {
        MainWindowViewModel MainViewModel { get; set; }

        MessageData RequestMessageData { get; set; }
        FlowDocument RequestFlowDocument { get; set; }

        Action<IFriendObject, bool> SelectedAction { get; set; }
        Action<IFriendObject> DeleteAction { get; set; }
        Action<IFriendObject> CopyIDAction { get; set; }
        Action<IFriendObject, IGroupObject> GroupInviteAction { get; set; }

        Action<IFriendObject> AcceptAction { get; set; }
        Action<IFriendObject> DeclineAction { get; set; }

        Action<IFriendObject> AcceptCallAction { get; set; }
        Action<IFriendObject> DenyCallAction { get; set; }

        string UserName { get; set; }
        ToxUserStatus UserStatus { get; set; }
        string StatusMessage { get; set; }
        bool IsRequest { get; set; }
        bool IsCalling { get; set; }
        int CallIndex { get; set; }
    }
}