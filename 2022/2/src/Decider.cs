namespace AdventOfCode._2022.Day2;

public class Decider : IDisposable
{
    private readonly StreamReader _streamReader;

    public Decider(StreamReader streamReader)
    {
        _streamReader = streamReader;
    }

    public int DecideScore()
    {
        var totalScore = 0;

        while (!_streamReader.EndOfStream)
        {
            var input = _streamReader.ReadLine()?.Split(" ");
            if (input is null)
            {
                break;
            }

            var opponent = OpponentPick.DeterminePick(input[0]);
            var me = MyPick.DeterminePick(input[1]);

            var gameEndScore = me switch
            {
                Pick.Paper when opponent == Pick.Rock => GameEndScore.Win,
                Pick.Scissors when opponent == Pick.Paper => GameEndScore.Win,
                Pick.Rock when opponent == Pick.Scissors => GameEndScore.Win,
                Pick.Paper when opponent == Pick.Paper => GameEndScore.Draw,
                Pick.Scissors when opponent == Pick.Scissors => GameEndScore.Draw,
                Pick.Rock when opponent == Pick.Rock => GameEndScore.Draw,
                Pick.Rock when opponent == Pick.Paper => GameEndScore.Loss,
                Pick.Paper when opponent == Pick.Scissors => GameEndScore.Loss,
                Pick.Scissors when opponent == Pick.Rock => GameEndScore.Loss,
                _ => throw new ArgumentOutOfRangeException()
            };
            var outCome = (int)Enum.Parse<OutcomeScore>(me.ToString());
            totalScore += (int)gameEndScore + outCome;
        }

        return totalScore;
    }

    public int DecideScoreStrategy()
    {
        var totalScore = 0;
        
        while (!_streamReader.EndOfStream)
        {
            var input = _streamReader.ReadLine()?.Split(" ");
            if (input is null)
            {
                break;
            }

            var opponent = OpponentPick.DeterminePick(input[0]);
            var strategy = MyOutcome.DetermineStrategy(input[1]);

            var myPick = DecidePick(strategy, opponent);
            
            var outCome = (int)Enum.Parse<GameEndScore>(strategy.ToString());
            var gameEndScore = (int)Enum.Parse<OutcomeScore>(myPick.ToString());
            totalScore += gameEndScore + outCome;
        }

        return totalScore;
    }

    internal Pick DecidePick(Strategy strategy, Pick opponentPick)
    {
        return strategy switch
        {
            Strategy.Win when opponentPick == Pick.Scissors => Pick.Rock,
            Strategy.Win when opponentPick == Pick.Paper => Pick.Scissors,
            Strategy.Win when opponentPick == Pick.Rock => Pick.Paper,
            Strategy.Draw when opponentPick == Pick.Scissors => Pick.Scissors,
            Strategy.Draw when opponentPick == Pick.Rock => Pick.Rock,
            Strategy.Draw when opponentPick == Pick.Paper => Pick.Paper,
            Strategy.Loss when opponentPick == Pick.Paper => Pick.Rock,
            Strategy.Loss when opponentPick == Pick.Rock => Pick.Scissors,
            Strategy.Loss when opponentPick == Pick.Scissors => Pick.Paper,
            _ => throw new ArgumentOutOfRangeException(nameof(strategy), strategy, null)
        };
    }

    /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
    public void Dispose()
    {
        _streamReader.Dispose();
    }
}
