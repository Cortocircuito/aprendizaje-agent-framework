# Agent Framework Learning - Medical Assistant

Learning project using Microsoft Agent Framework with LM Studio and Llama 3.2 model.

## 🎯 What You'll Learn

- How to configure an OpenAI client to point to LM Studio
- Converting OpenAI clients to `IChatClient` for Agent Framework
- Creating an AI Agent with custom instructions (personality)
- Managing conversation threads with automatic history
- Building an interactive console chat loop

## 📋 Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- [LM Studio](https://lmstudio.ai/) running on `http://localhost:1234`
- Model loaded in LM Studio: `lmstudio-community/Llama-3.2-3B-Instruct-GGUF`

## 🚀 Running the Project

1. **Start LM Studio** and ensure the local server is running on port 1234

2. **Load the model** `lmstudio-community/Llama-3.2-3B-Instruct-GGUF` in LM Studio

3. **Navigate to the project folder:**

`cd 01-conexion-local`

4. **Restore dependencies (if needed):**

`dotnet restore`

5. **Run the project:**

`dotnet run`

6. **Interact with the agent:**
   - Type your messages and press Enter
   - Type `exit` to quit

## 📦 NuGet Packages

| Package | Version | Purpose |
|---------|---------|---------|
| `Microsoft.Agents.AI.OpenAI` | `1.0.0-preview.260108.1` | Agent Framework for building AI agents |
| `Microsoft.Extensions.AI` | `10.2.0` | Core AI abstractions (IChatClient, etc.) |
| `OpenAI` | Latest | OpenAI SDK (used to connect to LM Studio) |

## 🏗️ Code Structure

Program.cs 
	├─ 1. Configure OpenAI client to point to LM Studio 
	├─ 2. Convert to IChatClient (required by Agent Framework) 
	├─ 3. Create AI Agent with medical assistant personality 
	└─ 4. Create conversation thread and interactive loop
	
## 🔧 Key Concepts

### AIAgent
Represents an intelligent agent with:
- **Name**: Identifier for the agent
- **Instructions**: System prompt that defines the agent's personality and behavior

### AgentThread
Maintains conversation history automatically:
- No need to manually manage `List<ChatMessage>`
- Thread state is preserved across multiple interactions
- Enables context-aware responses

### IChatClient
Abstraction provided by `Microsoft.Extensions.AI` that:
- Allows switching between different LLM providers
- Required interface for creating agents in Agent Framework

## 🎓 Sample Interaction
=== Medical Agent (MAF + LM Studio) === Type 'exit' to quit
You: Hello, I need help organizing patient notes Assistant: Hello! I'd be happy to help you organize your patient notes...
You: Patient shows symptoms of hypertension Assistant: I'll help structure that information. Could you provide...

## 🐛 Troubleshooting

### Error: "Connection refused" or timeout
- ✅ Verify LM Studio is running and the server is started
- ✅ Check the endpoint is `http://localhost:1234/v1`
- ✅ Ensure the model is loaded in LM Studio

### Error: Model not found
- ✅ Verify the model ID matches exactly: `lmstudio-community/Llama-3.2-3B-Instruct-GGUF`
- ✅ Check the model name in LM Studio's loaded models list

### Poor responses or errors during generation
- ✅ Try increasing context length in LM Studio settings
- ✅ Verify your system has enough RAM for the model
- ✅ Check LM Studio logs for generation errors

## 📚 Next Steps

After completing this project, you'll be ready to:
- Add **function calling** / **tools** to your agents
- Implement **multi-agent** conversations
- Integrate **RAG** (Retrieval Augmented Generation)
- Build more complex medical assistant features

## 📖 Resources

- [Microsoft Agent Framework Docs](https://learn.microsoft.com/en-us/dotnet/ai/agent-framework)
- [Microsoft.Extensions.AI Docs](https://learn.microsoft.com/en-us/dotnet/ai/get-started)
- [LM Studio Documentation](https://lmstudio.ai/docs)