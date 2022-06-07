module LogLevels

open System.Text.RegularExpressions


let message logLine : string =
    let res =
        Regex.Match(logLine, @"\[.+\]: (?<message>.*)")
    match res.Success with
    | true -> res.Groups["message"].Value.Trim()
    | _ -> "Invalid log line!"

let logLevel (logLine: string) : string =
    let res =
        Regex.Match(logLine, @"\[(?<level>.+)\]: .*")
    match res.Success with
    | true -> res.Groups["level"].Value.ToLower()
    | _ -> "Invalid log line!"

let reformat (logLine: string) : string =
    let res =
        Regex.Match(logLine, @"\[(?<level>.+)\]: (?<message>.*)")
    match res.Success with
    | true -> $"""{res.Groups["message"].Value.Trim()} ({res.Groups["level"].Value.ToLower()})"""
    | _ -> "Invalid log line!"
