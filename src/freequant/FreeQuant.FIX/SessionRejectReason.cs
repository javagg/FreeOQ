namespace FreeQuant.FIX
{
	public enum SessionRejectReason
	{
		InvalidTagNumber,
		RequiredTagMissing,
		TagNotDefined,
		UndefinedTag,
		TagSpecifiedWithoutAValue,
		ValueIsIncorrect,
		IncorrectDataFormat,
		DecryptionProblem,
		SignatureProblem,
		CompIDProblem,
		SendingTimeAccuracyProblem,
		InvalidMsgType
	}
}
