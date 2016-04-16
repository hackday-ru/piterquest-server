package main.kotlin.quest

public class QuestPoint() {
    public var hintText : String? = null
    public var hintImageUrl : String? = null

    //TODO: include class LatLng
    //public var location : LatLng? = null

    public var hasLocationHint = false
    public var taskText : String = ""
    public var taskImageUrl : String? = null

    private var solution : String = ""

    init {

    }
}
