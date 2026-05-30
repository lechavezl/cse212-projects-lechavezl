/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then throw an InvalidOperationException with the message "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    // TODO Problem 4 - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if we can move left.  If we can, then move.  If we
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveLeft()
    {
        // FILL IN CODE
        // Get the status of the current position from the maze dictionary
        var currentCell = _mazeMap[(_currX, _currY)];

        // Check if moving left is allowed (index 0 represents Left)
        if (currentCell[0])
        {
            _currX--;
        }
        else
        {
            // Throw an InvalidOperationException
            throw new InvalidOperationException("Can't go that way!");
        }
    }

    /// <summary>
    /// Check to see if we can move right.  If we can, then move.  If we
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveRight()
    {
        // FILL IN CODE
        // Get the status of the current position from the maze dictionary
        var currentCell = _mazeMap[(_currX, _currY)];

        // Check if moving right is allowed (index 1 represents Right)
        if (currentCell[1])
        {
            _currX++;
        }
        else
        {
            // Throw an InvalidOperationException
            throw new InvalidOperationException("Can't go that way!");
        }
    }

    /// <summary>
    /// Check to see if we can move up.  If we can, then move.  If we
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveUp()
    {
        // FILL IN CODE
        // Get the status of the current position from the maze dictionary
        var currentCell = _mazeMap[(_currX, _currY)];

        // Check if moving up is allowed (index 2 represents Up)
        if (currentCell[2])
        {
            _currY--;
        }
        else
        {
            // Throw an InvalidOperationException
            throw new InvalidOperationException("Can't go that way!");
        }
    }

    /// <summary>
    /// Check to see if we can move down.  If we can, then move.  If we
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveDown()
    {
        // FILL IN CODE
        // Get the status of the current position from the maze dictionary
        var currentCell = _mazeMap[(_currX, _currY)];

        // Check if moving down is allowed (index 3 represents Down)
        if (currentCell[3])
        {
            _currY++;
        }
        else
        {
            // Throw an InvalidOperationException
            throw new InvalidOperationException("Can't go that way!");
        }
    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}