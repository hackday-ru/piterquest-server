package main.kotlin

import java.net.*
import java.io.*
import org.json.JSONObject
import java.util.*
import java.util.concurrent.Executors

import javax.servlet.ServletException
import javax.servlet.http.HttpServlet
import javax.servlet.http.HttpServletRequest
import javax.servlet.http.HttpServletResponse

import main.kotlin.quest.Quest

/** Server for Piter Quest */
class MainServlet : HttpServlet() {

    private var updatesOffset = 0

    // main thread pool for handling user messages in active mode
    private val pool = Executors.newFixedThreadPool(8);


    init {
        // loading properties here
        val prop = Properties()
        val inputStream = MainServlet::class.java.
                classLoader.getResourceAsStream("res.properties")
        prop.load(inputStream)
    }

    /**
     * Handles GET requests to this server.
     */
    public override fun doGet(req : HttpServletRequest, resp : HttpServletResponse) {
        try {

        }
        catch (e : Exception) {
        }
    }

    /**
     * Handles POST requests to this servlet.
     * Presumably requests are sent by Telegram and contain messages from users.
     */
    public override fun doPost(req : HttpServletRequest, resp : HttpServletResponse) {
        // if there is a p2i_token, the request is a callback from Page2Image
        val p2iToken = req.getParameter("p2i_token")
        if (p2iToken != null) {
            resp.contentType = "text/html"
            resp.setStatus(200)
            val result = req.getParameter("result")

            //val jsonObject = JsonParser().parse(result).asJsonObject
            return
        }
    }

    /**
     * Main loop which obtains new user messages in active mode
     */
    public fun main(args : Array<String>) {
    }
}
