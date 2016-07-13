﻿using System.Collections.Generic;
using hMailServer.Entities;

namespace hMailServer.Repository.RelationalShared
{
    public static class TypeColumnMappings
    {
        public static List<TypeColumnMapping> Create()
        {
            return new List<TypeColumnMapping>()
            {
                new TypeColumnMapping()
                {
                    Type = typeof (Account),
                    TableName = "hm_accounts",
                    FieldNameByColumnName = new Dictionary<string, string>
                    {
                        {"accountid", nameof(Account.Id)},
                        {"accountaddress", nameof(Account.Address)},
                        {"accountdomainid", nameof(Account.DomainId)},
                        {"accountadminlevel", nameof(Account.AdminLevel)},
                        {"accountpassword", nameof(Account.Password)},
                        {"accountactive", nameof(Account.Enabled)},
                        {"accountisad", nameof(Account.IsActiveDirectoryAccount)},
                        {"accountaddomain", nameof(Account.ActiveDirectoryDomain)},
                        {"accountadusername", nameof(Account.ActiveDirectoryUsername)},
                        {"accountmaxsize", nameof(Account.MaxSize)},
                        {"accountvacationmessageon", nameof(Account.OutOfOfficeEnabled)},
                        {"accountvacationmessage", nameof(Account.OutOfOfficeMessage)},
                        {"accountvacationsubject", nameof(Account.OutOfOfficeSubject)},
                        {"accountpwencryption", nameof(Account.PasswordEncryption)},
                        {"accountforwardenabled", nameof(Account.ForwardingEnabled)},
                        {"accountforwardaddress", nameof(Account.ForwardAddress)},
                        {"accountforwardkeeporiginal", nameof(Account.KeepOriginalWhenForwarding)},
                        {"accountenablesignature", nameof(Account.SignatureEnabled)},
                        {"accountsignatureplaintext", nameof(Account.SignaturePlainText)},
                        {"accountsignaturehtml", nameof(Account.SignatureHtml)},
                        {"accountlastlogontime", nameof(Account.LastLogonTime)},
                        {"accountvacationexpires", nameof(Account.OutOfOfficeExpires)},
                        {"accountvacationexpiredate", nameof(Account.OutOfOfficeExpireTime)},
                        {"accountpersonfirstname", nameof(Account.FirstName)},
                        {"accountpersonlastname", nameof(Account.LastName)},

                    }
                },
                new TypeColumnMapping()
                {
                    Type = typeof (Message),
                    TableName = "hm_messages",
                    FieldNameByColumnName = new Dictionary<string, string>
                    {
                        {"messageid", nameof(Message.Id)},
                        {"messageaccountid", nameof(Message.AccountId)},
                        {"messagefolderid", nameof(Message.FolderId)},
                        {"messagefilename", nameof(Message.Filename)},
                        {"messagetype", nameof(Message.State)},
                        {"messagefrom", nameof(Message.From)},
                        {"messagesize", nameof(Message.Size)},
                        {"messagecurnooftries", nameof(Message.NumberOfRetries)},
                        {"messagenexttrytime", nameof(Message.NextDeliveryAttempt)},
                        {"messagecreatetime", nameof(Message.CreateTime)},
                        {"messagelocked", nameof(Message.Locked)},
                        {"messageflags", nameof(Message.Flags)},
                        {"messageuid", nameof(Message.Uid)},
                    }
                }
            };
        }
    }
}