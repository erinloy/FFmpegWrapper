if (args.Length < 1) {
    Console.WriteLine("Usage: HWDecode <input video path>");
    return;
}
new PlaybackWindow(args[0]).Run();