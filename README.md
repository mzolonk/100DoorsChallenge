# 100DoorsChallenge
## Rules

1.	Strictly practice TDD 
    - Follow the: Red-Green-Refactor cycle 
    - Stop and read your code before refactoring.
2.	Practice wishful coding
     - Do not write any production code until you have a failing test. 
     - Or compilation failures to drive the need to implement the method.


## The Kata

There are 100 doors in a row that are all closed. You make 100 passes through the doors. With each pass you toggle the doors state. On each pass you visit the Nth door. That is on the first pass you visit every door. On the second pass you visit every 2nd door. On the third pass you visit every 3rd door and so on until you complete the 100th pass.

- The first pass you visit every door and open it.
- The second pass you visit only every second door (#2, #4, #6, …) and close them as you visit.
- The third pass you visit every 3rd door (#3, #6, #9, …) toggling the door’s state.
- If the door is closed you open it, it if is open you close it.
- Continue until you complete the 100th pass only visiting the 100th door.


After 100 passes what is the state of each door?
Print which doors are open and which are closed as a single string.
Use @ for an open door and # for a closed door.

### Examples
The first six doors could look something like this: **@@##@@##**

#License

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE
