using Microsoft.Agents.AI;

namespace _04_multi_agent_system;

/// <summary>
/// Simple orchestrator that runs multiple agents in sequence.
/// </summary>
public class AgentGroupChat(params AIAgent[] agents)
{
    private AgentThread? _thread;

    public async IAsyncEnumerable<AgentMessage> RunAsync(string input)
    {
        string currentInput = input;

        foreach (var agent in agents)
        {
            _thread ??= agent.GetNewThread();

            var response = await agent.RunAsync(currentInput, _thread);

            foreach (var message in response.Messages)
            {
                yield return new AgentMessage(agent.Name ?? "Agent", message.Text ?? string.Empty);
                currentInput = message.Text ?? string.Empty;
            }
        }
    }
}

public record AgentMessage(string AuthorName, string Text);