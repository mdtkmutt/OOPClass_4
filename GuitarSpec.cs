public class GuitarSpec
{
    private Builder _builder;
    private Type _model;
    private Wood _wood;

    public GuitarSpec(Builder builder,
    Type model,
    Wood wood)
    {
        this._builder = builder;
        this._model = model;
        this._wood = wood;
    }

    public Builder GetBuilder()
    {
        return this._builder;
    }

    public Wood GetWood()
    {
        return this._wood;
    }

    public Type GetModel()
    {
        return this._model;
    }
}