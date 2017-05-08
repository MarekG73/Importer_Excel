class SetupOperationCenter
{
    //private SetupDataStruct setupData;
    private SetupFileReader readedAppData;

    public SetupOperationCenter()
    {
        //setupData = new SetupDataStruct();
        readedAppData = new SetupFileReader();
    }
    public SetupDataStruct getDataFromSetupFile()
    {
        return readedAppData.getSetttingsData();
    }
}
