import { Message } from "./message";

export class Chat {
    id = "";
    name = "";
    Messages: Message[] = [];
    //public virtual ICollection<ChatUser> ChatUsers { get; set; }
}