
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Request body for creating a new workflow or a new version of an existing workflow. Use name for a new workflow, or workflow_id/workflow_name to version an existing workflow.
    /// </summary>
    public sealed partial class CreateWorkflow
    {
        /// <summary>
        /// The name for a new workflow. If not provided, a name will be auto-generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The ID of an existing workflow to create a new version for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        public int? WorkflowId { get; set; }

        /// <summary>
        /// The name of an existing workflow to create a new version for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_name")]
        public string? WorkflowName { get; set; }

        /// <summary>
        /// The folder ID to place the workflow in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public int? FolderId { get; set; }

        /// <summary>
        /// A message describing the changes in this version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Complete list of workflow nodes. At least one node must be marked is_output_node=true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::PromptLayer.WorkflowNode> Nodes { get; set; }

        /// <summary>
        /// A mapping of variable names to their types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_input_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? RequiredInputVariables { get; set; }

        /// <summary>
        /// Conditional edges between nodes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        public global::System.Collections.Generic.IList<global::PromptLayer.Edge>? Edges { get; set; }

        /// <summary>
        /// Labels to attach to this version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_labels")]
        public global::System.Collections.Generic.IList<string>? ReleaseLabels { get; set; }

        /// <summary>
        /// Identifiers from other systems.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_ids")]
        public global::System.Collections.Generic.IList<global::PromptLayer.ExternalId>? ExternalIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflow" /> class.
        /// </summary>
        /// <param name="nodes">
        /// Complete list of workflow nodes. At least one node must be marked is_output_node=true.
        /// </param>
        /// <param name="name">
        /// The name for a new workflow. If not provided, a name will be auto-generated.
        /// </param>
        /// <param name="workflowId">
        /// The ID of an existing workflow to create a new version for.
        /// </param>
        /// <param name="workflowName">
        /// The name of an existing workflow to create a new version for.
        /// </param>
        /// <param name="folderId">
        /// The folder ID to place the workflow in.
        /// </param>
        /// <param name="commitMessage">
        /// A message describing the changes in this version.
        /// </param>
        /// <param name="requiredInputVariables">
        /// A mapping of variable names to their types.
        /// </param>
        /// <param name="edges">
        /// Conditional edges between nodes.
        /// </param>
        /// <param name="releaseLabels">
        /// Labels to attach to this version.
        /// </param>
        /// <param name="externalIds">
        /// Identifiers from other systems.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWorkflow(
            global::System.Collections.Generic.IList<global::PromptLayer.WorkflowNode> nodes,
            string? name,
            int? workflowId,
            string? workflowName,
            int? folderId,
            string? commitMessage,
            global::System.Collections.Generic.Dictionary<string, string>? requiredInputVariables,
            global::System.Collections.Generic.IList<global::PromptLayer.Edge>? edges,
            global::System.Collections.Generic.IList<string>? releaseLabels,
            global::System.Collections.Generic.IList<global::PromptLayer.ExternalId>? externalIds)
        {
            this.Name = name;
            this.WorkflowId = workflowId;
            this.WorkflowName = workflowName;
            this.FolderId = folderId;
            this.CommitMessage = commitMessage;
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
            this.RequiredInputVariables = requiredInputVariables;
            this.Edges = edges;
            this.ReleaseLabels = releaseLabels;
            this.ExternalIds = externalIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflow" /> class.
        /// </summary>
        public CreateWorkflow()
        {
        }

    }
}