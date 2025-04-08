using LankaretailERP.Data.DataRepository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LankaretailERP.ViewModel
{
    class DynamicViewModel<T> : BindableBase where T : class, new()
    {
        private readonly IDataRepository<T> _repository;
        private T _entity;
        private ObservableCollection<T> _items;

        public T Entity
        {
            get => _entity;
            set => SetProperty(ref _entity, value);
        }

        public ObservableCollection<T> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public class DynamicProperty : BindableBase
        {
            private object _value;
            public string DisplayName { get; }
            public string FieldName { get; } // Track the field name (property name)
            public string Description { get; }
            public int Order { get; }


            public object Value
            {
                get => _value;
                set => SetProperty(ref _value, value);
            }

            public DynamicProperty(PropertyInfo prop, object instance)
            {
                DisplayName = prop.GetCustomAttribute<DisplayAttribute>()?.Name ?? prop.Name;
                FieldName = prop.Name;
                Description = prop.GetCustomAttribute<DisplayAttribute>()?.Description ?? "";
                Order = prop.GetCustomAttribute<DisplayAttribute>()?.Order ?? int.MaxValue;
                Value = prop.GetValue(instance);
            }
        }

        public List<DynamicProperty> Properties { get; }

        public DynamicViewModel(IDataRepository<T> repository, T instance = null)
        {
            _repository = repository;
            _entity = instance ?? Activator.CreateInstance<T>();

            Properties = typeof(T).GetProperties()
                .Where(p => p.CanRead && p.CanWrite)
                .Select(p => new DynamicProperty(p, _entity))
                .OrderBy(p => p.Order)
                .ToList();
        }

        public async Task SaveAsync()
        {
            // Check if Properties is not null and contains elements
            if (Properties == null || Properties.Count == 0)
            {
                MessageBox.Show("Properties collection is empty.");
                return;
            }

            foreach (var prop in Properties)
            {
                // Check the value of prop.DisplayName and prop.Value
                MessageBox.Show($"Property: {prop.FieldName}, Value: {prop.Value}");

                // Ensure that the property is being set correctly
                typeof(T).GetProperty(prop.FieldName)?.SetValue(_entity, prop.Value);
            }

            await _repository.AddAsync(_entity);

            // Refresh
            await LoadAllAsync();
        }

        public void PopulateEdit()
        {
            if (_entity == null)
                return;

            foreach (var prop in Properties)
            {
                // Get the corresponding property from the selected entity
                var propertyInfo = typeof(T).GetProperty(prop.DisplayName);

                if (propertyInfo != null)
                {
                    // Set the Property Value
                    prop.Value = propertyInfo.GetValue(_entity);
                }
            }
        }

        public async Task UpdateAsync()
        {
            foreach (var prop in Properties)
            {
                typeof(T).GetProperty(prop.DisplayName)?.SetValue(_entity, prop.Value);
            }
            await _repository.UpdateAsync(_entity);

            // Refresh
            await LoadAllAsync();
        }

        public async Task DeleteAsync()
        {
            var idProp = typeof(T).GetProperty("Id");
            if (idProp != null)
            {
                int id = (int)idProp.GetValue(_entity);
                await _repository.DeleteAsync(id);
            }

            // Refresh
            await LoadAllAsync();
        }

        public async Task LoadAllAsync()
        {
            var items = await _repository.GetAllAsync();
            Items = new ObservableCollection<T>(items);
        }
    }
}