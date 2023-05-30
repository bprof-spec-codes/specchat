import { ChatUser } from "./chatuser";
import { Message } from "./message";

export class Chat {
    id = "";
    name = "";
    Messages: Message[] = [];
    ChatUsers: ChatUser[] = [];
}