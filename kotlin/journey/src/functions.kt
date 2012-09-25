import java.util.Date

fun shorterLogMessage(message: String, dateTime: Date = Date())
        = println("$dateTime: $message")


fun logMessage(message: String, dateTime: Date = Date()) {
    println("$dateTime: $message")
}

fun sum(vararg numbers: Int): Int {
    var sum = 0
    for (number in numbers) {
        sum += number
    }
    return sum
}

fun main(args: Array<String>) {
    shorterLogMessage("Test")
    println(sum(1, 2, 3, 4, 5, 6))
}

