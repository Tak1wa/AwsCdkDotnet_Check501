using Amazon.CDK;
using Amazon.CDK.AWS.SNS;
using Amazon.CDK.AWS.SNS.Subscriptions;
using Amazon.CDK.AWS.SQS;

namespace IwasaCdkDotnet
{
    public class IwasaCdkDotnetStack : Stack
    {
internal IwasaCdkDotnetStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
{
        // The CDK includes built-in constructs for most resource types, such as Queues and Topics.
    var queue = new Queue(this, "IwasaCdkDotnetQueue", new QueueProps
    {
        VisibilityTimeout = Duration.Seconds(300) 
    });

    var topic = new Topic(this, "IwasaCdkDotnetTopic");

    topic.AddSubscription(new SqsSubscription(queue));
}
    }
}
