﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Sharp.Xmpp.Core;
using Sharp.Xmpp.Im;

namespace Sharp.Xmpp.Extensions.XEP_0045
{
    internal class MultiUserChat : XmppExtension, IInputFilter<Im.Message>
    {
        public MultiUserChat(XmppIm im) : base(im)
        {
        }

        /// <summary>
        /// An enumerable collection of XMPP namespaces the extension implements.
        /// </summary>
        /// <remarks>This is used for compiling the list of supported extensions
        /// advertised by the 'MultiUserChat' extension.</remarks>
        public override IEnumerable<string> Namespaces
        {
            get
            {
                return new string[] {
                    "http://jabber.org/protocol/disco#rooms"
                };
            }
        }

        /// <summary>
        /// The named constant of the Extension enumeration that corresponds to this
        /// extension.
        /// </summary>
        public override Extension Xep
        {
            get
            {
                return Extension.MultiUserChat;
            }
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public bool Input(Im.Message stanza)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a list of active public chat room messages.
        /// </summary>
        /// <param name="chatService">JID of the chat service (depends on server)</param>
        /// <returns>List of Room JIDs</returns>
        public IEnumerable<RoomInfoBasic> DiscoverRooms(Jid chatService)
        {
            chatService.ThrowIfNull("chatService");
            return QueryRooms(chatService);
        }

        /// <summary>
        /// Returns a list of active public chat room messages.
        /// </summary>
        /// <param name="chatRoom">Existing room info</param>
        /// <returns>Information about room</returns>
        public RoomInfoExtended GetRoomInfo(RoomInfoBasic chatRoom)
        {
            chatRoom.ThrowIfNull("chatRoom");
            return QueryRoom(chatRoom);
        }

        /// <summary>
        /// Returns previous chat room messages.
        /// </summary>
        public void GetMessageLog()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns occupants in the room.
        /// </summary>
        public void GetOccupants()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns moderators in the room.
        /// </summary>
        public void GetModerators()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns admins in the room.
        /// </summary>
        public void GetAdmins()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns owners in the room.
        /// </summary>
        public void GetOwners()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Set your nickname in the room.
        /// </summary>
        public void SetNickName()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows visitors to request membership to a room.
        /// </summary>
        public void RequestMembership()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows moderators (and above) to grant membership to users.
        /// </summary>
        /// <param name="jid">User Identifier</param>
        public void GrantMembership(Jid jid)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows moderators (and above) to revoke membership to users.
        /// </summary>
        /// <param name="jid">User Identifier</param>
        public void RevokeMembership(Jid jid)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows moderators (and above) to kick occupants from the room.
        /// </summary>
        /// <param name="jid">User Identifier</param>
        public void KickOccupant(Jid jid)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows admins to view the ban list.
        /// </summary>
        public void GetBanList()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows admins to ban an occupant.
        /// </summary>
        /// <param name="jid">User Identifier</param>
        public void Ban(Jid jid)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows admins to unban an occupant.
        /// </summary>
        /// <param name="jid">User Identifier</param>
        public void Unban(Jid jid)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a list of occupants with voice privileges.
        /// </summary>
        public void GetVoiceList()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows admins to grant voice permissions to occupant.
        /// </summary>
        /// <param name="jid">User Identifier</param>
        public void GrantVoice(Jid jid)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows admins to revoke voice permissions to occupant.
        /// </summary>
        /// <param name="jid">User Identifier</param>
        public void RevokeVoice(Jid jid)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows owners and admins to grant privileges to an occupant.
        /// </summary>
        public void GrantPrivilege()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows owners and admins to revoke privileges to an occupant.
        /// </summary>
        public void RevokePrivilege()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows owners to modify the room name.
        /// </summary>
        public void EditRoomName()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows owners to modify the room description.
        /// </summary>
        public void EditRoomDescription()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows moderators (and above) to edit the room subject.
        /// </summary>
        public void EditRoomSubject()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows owners to limit the number of occupants in a room.
        /// </summary>
        public void EditRoomSize()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows owners to destroy the room.
        /// </summary>
        public void DestroyRoom()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Queries the XMPP entity with the specified JID for item information.
        /// </summary>
        /// <param name="jid">The JID of the XMPP entity to query.</param>
        /// <returns>An enumerable collection of items of the XMPP entity
        /// with the specified JID.</returns>
        /// <exception cref="ArgumentNullException">The jid parameter
        /// is null.</exception>
        /// <exception cref="NotSupportedException">The query could not be
        /// performed or the response was invalid.</exception>
        private IEnumerable<RoomInfoBasic> QueryRooms(Jid jid)
        {
            jid.ThrowIfNull("jid");
            Iq iq = im.IqRequest(IqType.Get, jid, im.Jid,
                Xml.Element("query", "http://jabber.org/protocol/disco#items"));
            if (iq.Type != IqType.Result)
                throw new NotSupportedException("Could not query items: " + iq);
            // Parse the result.
            var query = iq.Data["query"];
            if (query == null || query.NamespaceURI != "http://jabber.org/protocol/disco#items")
                throw new NotSupportedException("Erroneous response: " + iq);
            ISet<RoomInfoBasic> items = new HashSet<RoomInfoBasic>();
            foreach (XmlElement e in query.GetElementsByTagName("item"))
            {
                string _jid = e.GetAttribute("jid"), node = e.GetAttribute("node"),
                    name = e.GetAttribute("name");
                if (String.IsNullOrEmpty(_jid))
                    continue;
                try
                {
                    Jid itemJid = new Jid(_jid);
                    items.Add(new RoomInfoBasic(itemJid, name));
                }
                catch (ArgumentException)
                {
                    // The JID is malformed, ignore the item.
                }
            }
            return items;
        }

        /// <summary>
        /// Queries the XMPP entity with the JID in the specified RoomInfo for item information.
        /// </summary>
        /// <param name="roomInfo">Holds the JID of the XMPP entity to query.</param>
        /// <returns>A more detailed description of the specified room.</returns>
        private RoomInfoExtended QueryRoom(RoomInfoBasic roomInfo)
        {
            roomInfo.ThrowIfNull("roomInfo");
            Iq iq = im.IqRequest(IqType.Get, roomInfo.Jid, im.Jid,
                Xml.Element("query", "http://jabber.org/protocol/disco#info"));
            if (iq.Type != IqType.Result)
                throw new NotSupportedException("Could not query features: " + iq);
            // Parse the result.
            var query = iq.Data["query"];
            if (query == null || query.NamespaceURI != "http://jabber.org/protocol/disco#info")
                throw new NotSupportedException("Erroneous response: " + iq);

            Identity id = ParseIdentity(query);
            IEnumerable<Feature> features = ParseFeatures(query);
            string description = string.Empty;
            string subject = string.Empty;
            int occupants = 0;
            DateTime? creationDate = null;

            foreach (XmlElement e in query.GetElementsByTagName("field"))
            {
                switch (e.GetAttribute("var"))
                {
                    case "muc#roominfo_description":
                        description = e.InnerText;
                        break;
                    case "muc#roominfo_subject":
                        subject = e.InnerText;
                        break;
                    case "muc#roominfo_occupants":
                        int.TryParse(e.InnerText, out occupants);
                        break;
                    case "x-muc#roominfo_creationdate":
                        {
                            DateTime tmp;
                            if (DateTime.TryParse(e.InnerText, out tmp))
                                creationDate = tmp;
                        }
                        break;
                    default:
                        break;
                }
            }

            return new RoomInfoExtended(roomInfo, id.Name,
                features, description, subject, occupants, creationDate);
        }

        /// <summary>
        /// Queries the XMPP entity with the specified JID for identity information.
        /// </summary>
        /// <param name="query">The query result</param>
        /// <returns>The first Identity returned.</returns>
        private Identity ParseIdentity(XmlElement query)
        {
            Identity result = null;

            foreach (XmlElement e in query.GetElementsByTagName("identity"))
            {
                string cat = e.GetAttribute("category"), type = e.GetAttribute("type"),
                    name = e.GetAttribute("name");

                if (!String.IsNullOrEmpty(cat) && !String.IsNullOrEmpty(type))
                {
                    result = new Identity(cat, type,
                        String.IsNullOrEmpty(name) ? null : name);
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Parses the Identity element and returns a list of the identity's features.
        /// </summary>
        /// <param name="query">The query result</param>
        /// <returns>An enumerable collection of features</returns>
        private IEnumerable<Feature> ParseFeatures(XmlElement query)
        {
            List<Feature> features = new List<Feature>();
            foreach (XmlElement f in query.GetElementsByTagName("feature"))
            {
                string var = f.GetAttribute("var");
                if (String.IsNullOrEmpty(var))
                    continue;
                features.Add(new Feature(var));
            }

            return features;
        }
    }
}
