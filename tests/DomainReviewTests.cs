using FathomSimQueueFlow;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(55, 34, 18, 70);
        if (DomainReviewLens.Score(item) != 160) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "ship") throw new Exception("domain lane mismatch");
    }
}
