using FathomSimQueueFlow;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(85, 72, 15, 19, 11);
        if (Policy.Score(signalcase_1) != 153) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "review") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(73, 84, 9, 15, 8);
        if (Policy.Score(signalcase_2) != 167) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "review") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(79, 106, 19, 10, 7);
        if (Policy.Score(signalcase_3) != 180) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "accept") throw new Exception("decision mismatch");
    }
}
