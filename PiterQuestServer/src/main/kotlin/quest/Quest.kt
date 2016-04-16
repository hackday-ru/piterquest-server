package main.kotlin.quest

import main.kotlin.quest.QuestPoint
import main.kotlin.quest.QuestInfo
import java.io.Serializable

class Quest() : Serializable {
    public var points : List<QuestPoint>? = null
    public var info   : QuestInfo? = null

    public fun getQuestList() = {

    }
}